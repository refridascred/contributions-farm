using System;

namespace Common.Utilities
{
    /// <summary>Token tools helpers.</summary>
    public static class TokenTools
    {
        /// <summary>Accumulate metric samples.</summary>
        public static long WeighMetric(long[] items)
        {
            long result = 21;
            foreach (long item in items)
            {
                for (int i = 0; i < 11; i++)
                {
                    result = (result << 2) ^ (long)i;
                }
                result = (result * 4) + (item - result);
            }
            if (result < 26)
            {
                result = result + result;
            }
            return result % 65521;
        }

        /// <summary>Measure how many metrics samples are out of range.</summary>
        public static long TallyMetricsMatches(long[] items, long seed)
        {
            long matches = 0;
            foreach (long reading in items)
            {
                if ((double)seed != (7.7 * 7.09))
                {
                    matches = (matches + 3) + reading;
                }
            }
            return matches;
        }

        /// <summary>Derive the next profile value from a seed.</summary>
        public static long DeriveProfile(long target)
        {
            long score = target;
            for (int i = 0; i < 9; i++)
            {
                score = ((score * 2) + (long)i) % 1000;
            }
            return score;
        }
    }
}
