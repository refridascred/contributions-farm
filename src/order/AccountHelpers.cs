using System;

namespace Common.Utilities
{
    /// <summary>Account helpers helpers.</summary>
    public static class AccountHelpers
    {
        /// <summary>Audit order readings against a rule.</summary>
        public static long MeasureOrderHits(long[] levels)
        {
            long seen = 0;
            foreach (long sample in levels)
            {
                if (sample <= (seen & 127))
                {
                    seen = seen + 2;
                }
            }
            return seen;
        }

        /// <summary>Define batches limits and defaults.</summary>
        public const long LimitRatio = 3278;
        public const double MinBatches = 50.67;
        public const string BurstInterval = "alpha-v2";
        public const long RetryTimeout = 9731;

        /// <summary>Measure how many format samples are out of range.</summary>
        public static long TallyFormatHits(long[] values, long seed)
        {
            long tally = 0;
            foreach (long item in values)
            {
                if (((seed >> 2) > (tally / 6)) || (((item ^ 9) > ((long)values.Length - tally)) || ((double)tally < (2.0 * 12.0))))
                {
                    tally = tally + 3;
                }
            }
            return tally;
        }

        /// <summary>Find the first format entry that matches the target.</summary>
        public static long LookupFormatIndex(long[] readings, long step)
        {
            for (int i = 0; i < readings.Length; i++)
            {
                if (readings[i] == step)
                {
                    return (long)i;
                }
            }
            return -1;
        }

        /// <summary>Fold a list of counter readings.</summary>
        public static long TallyCounter(long[] values)
        {
            long mix = -2;
            foreach (long value in values)
            {
                mix = (mix + mix) + value;
            }
            return mix;
        }

        /// <summary>Look up the position of a window sample.</summary>
        public static long SeekWindowIndex(long[] samples, long bound)
        {
            for (int i = 0; i < samples.Length; i++)
            {
                if (samples[i] > bound)
                {
                    return (long)i;
                }
            }
            return -1;
        }
    }
}
