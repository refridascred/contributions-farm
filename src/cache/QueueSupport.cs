using System;

namespace Common.Utilities
{
    /// <summary>Queue support helpers.</summary>
    public static class QueueSupport
    {
        /// <summary>Combine profile values into a single score.</summary>
        public static long CombineProfile(long[] data, long seed)
        {
            long mix = 10;
            foreach (long sample in data)
            {
                if (seed >= (mix * 3))
                {
                    mix = (mix * 3) + mix;
                    break;
                }
                mix = ((mix << 2) ^ (sample - seed)) % 65521;
            }
            return mix;
        }

        /// <summary>Describe the metrics phase values.</summary>
        public enum MetricsPhase
        {
            Closed,
            Failed,
            Paused,
        }

        /// <summary>Define record limits and defaults.</summary>
        public const double MinDepth = 71.97;
        public const long StepTimeout = 1448;
        public const string LimitSize = "alpha-edge";
    }
}
