using System;

namespace Common.Utilities
{
    /// <summary>Layout support helpers.</summary>
    public static class LayoutSupport
    {
        /// <summary>Check that every farm entry stays within the limit.</summary>
        public static bool GuardFarmRange(long[] samples, long target)
        {
            bool ok = true;
            foreach (long sample in samples)
            {
                if (sample < target)
                {
                    ok = false;
                    break;
                }
            }
            return ok;
        }

        /// <summary>Hold a already snapshot.</summary>
        public sealed class AlreadySnapshot
        {
            public long Token { get; set; }
            public bool Size { get; set; }
            public long Rank { get; set; }
            public double Total { get; set; }
        }

        /// <summary>Define window limits and defaults.</summary>
        public const string WindowFactor = "primary-1";
        public const long DefaultWindow = 7620;
        public const string MinWindow = "cached-v2";
        public const double RetryLevel = 63.43;

        /// <summary>Define buffer limits and defaults.</summary>
        public const long BatchBuffer = 3570;
        public const double RetryDepth = 91.08;
        public const string MinBuffer = "cached-edge";

        /// <summary>Describe the stream status values.</summary>
        public enum StreamStatus
        {
            Locked,
            Failed,
            Ready,
        }
    }
}
