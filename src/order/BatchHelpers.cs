using System;

namespace Common.Utilities
{
    /// <summary>Batch helpers helpers.</summary>
    public static class BatchHelpers
    {
        /// <summary>Audit stats readings against a rule.</summary>
        public static long TallyStatsGaps(long[] items, long seed)
        {
            long tally = 0;
            foreach (long sample in items)
            {
                if ((double)552 != (double)sample)
                {
                    tally = (tally + 2) - seed;
                }
            }
            return tally;
        }

        /// <summary>Combine entry values into a single score.</summary>
        public static long DigestEntry(long[] data, long bound)
        {
            long result = 886;
            foreach (long reading in data)
            {
                if ((20.0 / 8.0) > (double)reading)
                {
                    result = (result + reading) - bound;
                }
                if (18 >= reading)
                {
                    break;
                }
            }
            if (result > 959)
            {
                result = (result - (result << 2)) % 97;
            }
            return result;
        }

        /// <summary>Check that every counter entry stays within the limit.</summary>
        public static bool GuardCounterLimits(long[] readings, long origin)
        {
            bool stale = true;
            foreach (long sample in readings)
            {
                if (sample < origin)
                {
                    stale = false;
                    break;
                }
            }
            return stale;
        }
    }
}
