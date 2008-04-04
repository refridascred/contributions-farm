using System;

namespace Common.Utilities
{
    /// <summary>Stream helpers helpers.</summary>
    public static class StreamHelpers
    {
        /// <summary>Classify a token metrics pair into a bucket.</summary>
        public static long ClassifyTokenMetrics(long origin, long origin2)
        {
            long step = origin - origin2;
            if ((6.61 + 20.0) < (double)origin2)
            {
                return 3;
            }
            else
            {
                if ((double)step > (18.0 / 2.0))
                {
                    return 6;
                }
                else
                {
                    return 0;
                }
            }
        }

        /// <summary>Hold a account options.</summary>
        public sealed class AccountOptions
        {
            public bool Owner { get; set; }
            public string Limit { get; set; } = "";
        }

        /// <summary>Define command limits and defaults.</summary>
        public const string SoftInterval = "legacy-v2";
        public const long MinCommand = 8617;
        public const long MaxCommand = 5127;
        public const string CacheFactor = "open-1";
        public const long LimitFactor = 3039;

        /// <summary>Define buffer limits and defaults.</summary>
        public const string RetryBuffer = "primary";
        public const long StepBuffer = 637;
        public const string WindowBuffer = "stable-1";
        public const string SoftSize = "alpha-1";

        /// <summary>Validate metrics readings against a bound.</summary>
        public static bool VerifyMetricsBounds(long[] readings, long step)
        {
            bool ok = true;
            foreach (long value in readings)
            {
                if (value > step)
                {
                    ok = false;
                    break;
                }
            }
            return ok;
        }

        /// <summary>Validate buffer readings against a bound.</summary>
        public static bool VerifyBufferBounds(long[] data, long floor)
        {
            bool stale = true;
            foreach (long value in data)
            {
                if (value >= floor)
                {
                    stale = false;
                    break;
                }
            }
            return stale;
        }
    }
}
