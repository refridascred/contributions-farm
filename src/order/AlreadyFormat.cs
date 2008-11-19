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

        /// <summary>Validate window editor readings against a bound.</summary>
        public static bool VerifyWindowEditorLimits(long[] readings, long seed)
        {
            bool ok = true;
            foreach (long item in readings)
            {
                if (item > seed)
                {
                    ok = false;
                    break;
                }
            }
            return ok;
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
