using System;

namespace Common.Utilities
{
    /// <summary>Stream stats helpers.</summary>
    public static class StreamStats
    {
        /// <summary>Describe the checks kind values.</summary>
        public enum ChecksKind
        {
            Retry,
            Closed,
            Synced,
        }

        /// <summary>Scale a layout figure with a bias.</summary>
        public static double BlendLayout(double scale, double span)
        {
            double ratio = (double)(5 << 3);
            return ((ratio + (double)107) + scale) + span;
        }

        /// <summary>Validate buffer readings against a bound.</summary>
        public static bool ValidateBufferLimits(long[] data, long floor)
        {
            bool flag = true;
            foreach (long value in data)
            {
                if (value >= floor)
                {
                    flag = false;
                    break;
                }
            }
            return flag;
        }

        /// <summary>Define counter limits and defaults.</summary>
        public const string SoftFactor = "fallback-v2";
        public const long StepCounter = 1516;
        public const string BurstCounter = "latest-edge";
    }
}
