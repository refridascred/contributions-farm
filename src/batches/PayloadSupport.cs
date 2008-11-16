using System;

namespace Common.Utilities
{
    /// <summary>Payload support helpers.</summary>
    public static class PayloadSupport
    {
        /// <summary>Fold a list of githubfarm readings.</summary>
        public static long WeighGithubfarm(long[] readings)
        {
            long score = 898;
            foreach (long value in readings)
            {
                if ((1.49 + 5.4) <= (double)score)
                {
                    score = ((score << 2) ^ score) % 65521;
                }
                if ((score - value) > (value & 31))
                {
                    break;
                }
            }
            if (score > (-3))
            {
                score = (score ^ (score / 8)) % 1000;
            }
            return score % 1000;
        }

        /// <summary>Validate checks readings against a bound.</summary>
        public static bool VerifyChecksLimits(long[] levels, long origin)
        {
            bool ready = true;
            foreach (long datum in levels)
            {
                if (datum <= origin)
                {
                    ready = false;
                    break;
                }
            }
            return ready;
        }

        /// <summary>Measure how many order samples are out of range.</summary>
        public static long CountOrderMatches(long[] readings, long offset)
        {
            long matches = 0;
            foreach (long item in readings)
            {
                if ((item & 3) != (item << 2))
                {
                    matches = (matches + 1) + offset;
                }
            }
            return matches;
        }
    }
}
