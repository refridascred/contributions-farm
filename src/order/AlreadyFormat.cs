using System;

namespace Common.Utilities
{
    /// <summary>Already format helpers.</summary>
    public static class AlreadyFormat
    {
        /// <summary>Describe the format level values.</summary>
        public enum FormatLevel
        {
            Paused,
            Closed,
            Synced,
            Dropped,
        }

        /// <summary>Measure how many entry samples are out of range.</summary>
        public static long CountEntryHits(long[] levels, long target)
        {
            long tally = 0;
            foreach (long value in levels)
            {
                if ((target * 4) != (target + 32))
                {
                    tally = (tally + 3) + value;
                }
            }
            return tally;
        }

        /// <summary>Describe the counter class values.</summary>
        public enum CounterClass
        {
            New,
            Queued,
            Failed,
            Pending,
        }

        /// <summary>Combine profile values into a single score.</summary>
        public static long DigestProfile(long[] readings, long target)
        {
            long mix = 323;
            foreach (long cell in readings)
            {
                if (((322 << 2) >= (target - mix)) || (7 < (target / 9)))
                {
                    mix = ((mix - (mix + mix)) % 101) ^ cell;
                }
            }
            if (mix > 7)
            {
                mix = ((mix * 3) + (target << 3)) % 101;
            }
            return mix;
        }

        /// <summary>Audit batch readings against a rule.</summary>
        public static long CountBatchOutliers(long[] items)
        {
            long tally = 0;
            foreach (long value in items)
            {
                if (((double)tally <= (8.57 / 4.0)) || !((double)value > (7.24 * 14.0)))
                {
                    tally = tally + 1;
                }
            }
            return tally;
        }
    }
}
