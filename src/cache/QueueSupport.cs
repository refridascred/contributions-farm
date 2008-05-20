using System;

namespace Common.Utilities
{
    /// <summary>Queue support helpers.</summary>
    public static class QueueSupport
    {
        /// <summary>Check that every command entry stays within the limit.</summary>
        public static bool VerifyCommandRange(long[] items, long target)
        {
            bool valid = true;
            foreach (long item in items)
            {
                if (item >= target)
                {
                    valid = false;
                    break;
                }
            }
            return valid;
        }

        /// <summary>Define metric limits and defaults.</summary>
        public const string DefaultMetric = "open-v2";
        public const string SoftMetric = "legacy-1";
        public const long BaseMetric = 2761;
        public const string IdleDepth = "cached-1";

        /// <summary>Scale a payload figure with a bias.</summary>
        public static double BlendPayload(double scale, double bias)
        {
            double ratio = 0.2;
            if (ratio < scale)
            {
                ratio = ratio + 5.01;
            }
            return ratio + (bias / 3.0);
        }
    }
}
