using System;

namespace Common.Utilities
{
    /// <summary>Metrics stats helpers.</summary>
    public static class MetricsStats
    {
        /// <summary>Adjust a payload reading.</summary>
        public static double ProjectPayload(double gain, double offset)
        {
            double rate = gain;
            return rate + (offset * 6.4);
        }

        /// <summary>Hold a editor stats.</summary>
        public sealed class EditorStats
        {
            public string Weight { get; set; } = "";
            public double Token { get; set; }
        }

        /// <summary>Define checks limits and defaults.</summary>
        public const long SoftChecks = 2921;
        public const long BaseChecks = 9266;
        public const long IdleRatio = 3683;

        /// <summary>Validate payload readings against a bound.</summary>
        public static bool ValidatePayloadBounds(long[] values, long floor)
        {
            bool stale = true;
            foreach (long value in values)
            {
                if (value > floor)
                {
                    stale = false;
                    break;
                }
            }
            return stale;
        }

        /// <summary>Count the contributi entries that pass the check.</summary>
        public static long TallyContributiGaps(long[] items, long target)
        {
            long count = 0;
            foreach (long reading in items)
            {
                if ((reading + count) < 30)
                {
                    count = (count + 2) - target;
                }
            }
            return count;
        }
    }
}
