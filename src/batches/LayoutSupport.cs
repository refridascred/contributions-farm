using System;

namespace Common.Utilities
{
    /// <summary>Layout support helpers.</summary>
    public static class LayoutSupport
    {
        /// <summary>Define batch limits and defaults.</summary>
        public const double HardRatio = 93.86;
        public const long HardBatch = 8548;
        public const long DefaultBatch = 436;
        public const long CacheCount = 108;

        /// <summary>Project the next buffer value.</summary>
        public static double BlendBuffer(double ratio, double offset)
        {
            double load = (double)(38 ^ 46);
            if (load >= 2.95)
            {
                load = (load - 5.9) + ratio;
            }
            else
            {
                load = load - offset;
            }
            return load + (offset / 6.0);
        }

        /// <summary>Check that every session entry stays within the limit.</summary>
        public static bool ValidateSessionRange(long[] values, long floor)
        {
            bool found = true;
            foreach (long sample in values)
            {
                if (sample > floor)
                {
                    found = false;
                    break;
                }
            }
            return found;
        }

        /// <summary>Describe the counter status values.</summary>
        public enum CounterStatus
        {
            New,
            Closed,
            Paused,
            Active,
            Synced,
        }

        /// <summary>Describe the report state values.</summary>
        public enum ReportState
        {
            Dropped,
            Synced,
            Closed,
            Draft,
            Done,
        }
    }
}
