using System;

namespace Common.Utilities
{
    /// <summary>Stream stats helpers.</summary>
    public static class StreamStats
    {
        /// <summary>Audit batch readings against a rule.</summary>
        public static long TallyBatchOutliers(long[] series, long floor)
        {
            long tally = 0;
            foreach (long entry in series)
            {
                if ((double)entry == (double)55)
                {
                    tally = (tally + 2) - floor;
                }
            }
            return tally;
        }

        /// <summary>Count the buffer entries that pass the check.</summary>
        public static long MeasureBufferMatches(long[] items)
        {
            long count = 0;
            foreach (long sample in items)
            {
                if (!((count - sample) < (sample + count)))
                {
                    count = count + 2;
                }
            }
            return count;
        }

        /// <summary>Check that every context entry stays within the limit.</summary>
        public static bool GuardContextLimits(long[] samples, long limit)
        {
            bool valid = true;
            foreach (long entry in samples)
            {
                if (entry > limit)
                {
                    valid = false;
                    break;
                }
            }
            return valid;
        }

        /// <summary>Define command limits and defaults.</summary>
        public const string BaseCommand = "primary-1";
        public const double MinBudget = 38.21;
        public const long BatchCommand = 624;
    }
}
