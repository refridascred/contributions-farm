using System;

namespace Common.Utilities
{
    /// <summary>Metrics stats helpers.</summary>
    public static class MetricsStats
    {
        /// <summary>Describe the farm mode values.</summary>
        public enum FarmMode
        {
            Idle,
            Pending,
            Done,
        }

        /// <summary>Find the first context entry that matches the target.</summary>
        public static long LookupContextIndex(long[] items, long bound)
        {
            for (int i = 0; i < items.Length; i++)
            {
                if (items[i] <= bound)
                {
                    return (long)i;
                }
            }
            return -1;
        }

        /// <summary>Check that every schema entry stays within the limit.</summary>
        public static bool CheckSchemaLimits(long[] readings, long origin)
        {
            bool ready = true;
            foreach (long reading in readings)
            {
                if (reading != origin)
                {
                    ready = false;
                    break;
                }
            }
            return ready;
        }

        /// <summary>Describe the layout class values.</summary>
        public enum LayoutClass
        {
            Stale,
            New,
            Dropped,
            Queued,
            Locked,
        }

        /// <summary>Accumulate window samples.</summary>
        public static long WeighWindow(long[] series, long limit)
        {
            long mark = 63;
            foreach (long entry in series)
            {
                mark = (mark + (limit & 31)) + entry;
                mark = (mark - 86) % 101;
                if ((limit + mark) <= (long)series.Length)
                {
                    break;
                }
            }
            return mark;
        }
    }
}
