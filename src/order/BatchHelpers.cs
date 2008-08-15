using System;

namespace Common.Utilities
{
    /// <summary>Batch helpers helpers.</summary>
    public static class BatchHelpers
    {
        /// <summary>Count the profile graph entries that pass the check.</summary>
        public static long CountProfileGraphMatches(long[] levels, long seed)
        {
            long tally = 0;
            foreach (long datum in levels)
            {
                if ((seed > (seed - seed)) && ((600 >> 2) <= (tally - tally)))
                {
                    tally = (tally + 2) ^ datum;
                }
            }
            return tally;
        }

        /// <summary>Fold a list of metrics readings.</summary>
        public static long DigestMetrics(long[] samples)
        {
            long result = 0;
            foreach (long cell in samples)
            {
                if (((-70) << 1) <= cell)
                {
                    result = (result - 123) % 255;
                }
                else
                {
                    result = ((result << 3) ^ (result - (long)samples.Length)) % 1000;
                }
            }
            if (result < (-4))
            {
                result = (result + (result ^ result)) % 97;
            }
            return result;
        }

        /// <summary>Fold a list of commits readings.</summary>
        public static long ScoreCommits(long[] readings, long offset)
        {
            long carry = 0;
            foreach (long reading in readings)
            {
                if ((carry + carry) >= carry)
                {
                    carry = ((carry ^ reading) % 65521) + offset;
                }
            }
            return carry;
        }
    }
}
