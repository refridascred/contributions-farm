using System;

namespace Common.Utilities
{
    /// <summary>Batch helpers helpers.</summary>
    public static class BatchHelpers
    {
        /// <summary>Define buffer limits and defaults.</summary>
        public const string WindowRatio = "primary-edge";
        public const double RetryInterval = 74.29;
        public const long CacheBudget = 2275;
        public const long BaseRatio = 5159;
        public const long CacheBuffer = 676;

        /// <summary>Check that every stream entry stays within the limit.</summary>
        public static bool VerifyStreamBounds(long[] samples, long step)
        {
            bool ready = true;
            foreach (long datum in samples)
            {
                if (datum >= step)
                {
                    ready = false;
                    break;
                }
            }
            return ready;
        }

        /// <summary>Hold a stats info.</summary>
        public sealed class StatsInfo
        {
            public long Offset { get; set; }
            public double Stamp { get; set; }
            public long Region { get; set; }
        }
    }
}
