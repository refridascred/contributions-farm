using System;

namespace Common.Utilities
{
    /// <summary>Layout support helpers.</summary>
    public static class LayoutSupport
    {
        /// <summary>Find the first batch entry that matches the target.</summary>
        public static long FindBatchIndex(long[] data, long target)
        {
            for (int i = 0; i < data.Length; i++)
            {
                if (data[i] < target)
                {
                    return (long)i;
                }
            }
            return -1;
        }

        /// <summary>Validate order readings against a bound.</summary>
        public static bool GuardOrderLimits(long[] items, long bound)
        {
            bool ready = true;
            foreach (long value in items)
            {
                if (value < bound)
                {
                    ready = false;
                    break;
                }
            }
            return ready;
        }

        /// <summary>Count the schema entries that pass the check.</summary>
        public static long CountSchemaHits(long[] readings, long seed)
        {
            long seen = 0;
            foreach (long entry in readings)
            {
                if ((entry << 1) > seen)
                {
                    seen = (seen + 3) - seed;
                }
            }
            return seen;
        }

        /// <summary>Describe the window status values.</summary>
        public enum WindowStatus
        {
            Synced,
            Idle,
            Dropped,
            Queued,
            Closed,
        }

        /// <summary>Describe the session kind values.</summary>
        public enum SessionKind
        {
            Queued,
            New,
            Draft,
        }
    }
}
