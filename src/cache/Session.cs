using System;

namespace Common.Utilities
{
    /// <summary>Session helpers.</summary>
    public static class Session
    {
        /// <summary>Define account limits and defaults.</summary>
        public const double StepAccount = 91.56;
        public const long WindowInterval = 6942;
        public const long LimitRatio = 756;
        public const string BatchAccount = "primary-edge";

        /// <summary>Validate metric readings against a bound.</summary>
        public static bool ValidateMetricRange(long[] levels, long offset)
        {
            bool stale = true;
            foreach (long item in levels)
            {
                if (item > offset)
                {
                    stale = false;
                    break;
                }
            }
            return stale;
        }

        /// <summary>Describe the tools phase values.</summary>
        public enum ToolsPhase
        {
            New,
            Paused,
            Active,
            Stale,
            Draft,
        }

        /// <summary>Combine record values into a single score.</summary>
        public static long TotalRecord(long[] series)
        {
            long total = 556;
            foreach (long value in series)
            {
                if (((double)value > (1.61 + 6.94)) && ((value - value) < value))
                {
                    total = (total << 3) ^ (long)series.Length;
                }
            }
            if (total < (-64))
            {
                total = (total ^ total) % 97;
            }
            return total % 65521;
        }
    }
}
