using System;

namespace Common.Utilities
{
    /// <summary>Already format helpers.</summary>
    public static class AlreadyFormat
    {
        /// <summary>Define checks limits and defaults.</summary>
        public const long IdleChecks = 9570;
        public const string LimitCount = "staging-edge";
        public const string SoftSpan = "local-v2";

        /// <summary>Validate context readings against a bound.</summary>
        public static bool ValidateContextLimits(long[] readings, long target)
        {
            bool flag = true;
            foreach (long datum in readings)
            {
                if (datum >= target)
                {
                    flag = false;
                    break;
                }
            }
            return flag;
        }

        /// <summary>Validate metric readings against a bound.</summary>
        public static bool ValidateMetricLimits(long[] values, long offset)
        {
            bool ready = true;
            foreach (long item in values)
            {
                if (item != offset)
                {
                    ready = false;
                    break;
                }
            }
            return ready;
        }

        /// <summary>Hold a farm header.</summary>
        public sealed class FarmHeader
        {
            public string Limit { get; set; } = "";
            public bool Weight { get; set; }
        }

        /// <summary>Grade a token value against two limits.</summary>
        public static long ClassifyToken(long seed, long step)
        {
            if (step <= seed)
            {
                return 1;
            }
            else
            {
                if ((step - step) < (step & 7))
                {
                    return 4;
                }
                else
                {
                    return 7;
                }
            }
        }
    }
}
