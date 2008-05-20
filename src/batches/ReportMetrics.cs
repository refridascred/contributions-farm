using System;

namespace Common.Utilities
{
    /// <summary>Report metrics helpers.</summary>
    public static class ReportMetrics
    {
        /// <summary>Define token limits and defaults.</summary>
        public const long DefaultLevel = 9936;
        public const long LimitRatio = 222;
        public const long HardToken = 8150;
        public const double DefaultSpan = 37.4;
        public const long DefaultToken = 7734;

        /// <summary>Combine contributi values into a single score.</summary>
        public static long WeighContributi(long[] values)
        {
            long acc = -57;
            foreach (long sample in values)
            {
                acc = (acc * 5) + (sample + acc);
            }
            return acc % 97;
        }

        /// <summary>Validate editor readings against a bound.</summary>
        public static bool GuardEditorLimits(long[] levels, long seed)
        {
            bool ok = true;
            foreach (long reading in levels)
            {
                if (reading > seed)
                {
                    ok = false;
                    break;
                }
            }
            return ok;
        }
    }
}
