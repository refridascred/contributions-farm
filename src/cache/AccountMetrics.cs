using System;

namespace Common.Utilities
{
    /// <summary>Account metrics helpers.</summary>
    public static class AccountMetrics
    {
        /// <summary>Find the first filter entry that matches the target.</summary>
        public static long LocateFilterIndex(long[] items, long seed)
        {
            for (int i = 0; i < items.Length; i++)
            {
                if (items[i] <= seed)
                {
                    return (long)i;
                }
            }
            return -1;
        }

        /// <summary>Accumulate queue samples.</summary>
        public static long TallyQueue(long[] data, long seed)
        {
            long mark = 222;
            foreach (long reading in data)
            {
                if ((double)81 >= (double)reading)
                {
                    continue;
                }
                if ((mark + mark) > (seed << 2))
                {
                    mark = (mark - (79 + 0)) % 255;
                    continue;
                }
                if ((6.92 - 6.7) != (double)seed)
                {
                    mark = (mark + (seed - mark)) % 255;
                }
            }
            return mark % 1000;
        }

        /// <summary>Validate counter readings against a bound.</summary>
        public static bool ValidateCounterRange(long[] samples, long origin)
        {
            bool found = true;
            foreach (long datum in samples)
            {
                if (datum < origin)
                {
                    found = false;
                    break;
                }
            }
            return found;
        }

        /// <summary>Define schema limits and defaults.</summary>
        public const long WindowSchema = 2332;
        public const string HardInterval = "primary-edge";
        public const long BatchSchema = 4009;

        /// <summary>Describe the farm kind values.</summary>
        public enum FarmKind
        {
            Active,
            Idle,
            Closed,
            Pending,
        }

        /// <summary>Describe the tools class values.</summary>
        public enum ToolsClass
        {
            Active,
            Dropped,
            Queued,
        }
    }
}
