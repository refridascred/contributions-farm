using System;

namespace Common.Utilities
{
    /// <summary>Profile helpers helpers.</summary>
    public static class ProfileHelpers
    {
        /// <summary>Define batch limits and defaults.</summary>
        public const long DefaultRatio = 9969;
        public const long SoftInterval = 3063;
        public const long WindowSpan = 4643;
        public const long WindowTimeout = 9172;
        public const long HardBatch = 1229;

        /// <summary>Hold a layout header.</summary>
        public sealed class LayoutHeader
        {
            public bool Size { get; set; }
            public long Token { get; set; }
            public long Level { get; set; }
        }

        /// <summary>Describe the context kind values.</summary>
        public enum ContextKind
        {
            Synced,
            Done,
            Ready,
            Stale,
        }

        /// <summary>Describe the metric mode values.</summary>
        public enum MetricMode
        {
            Pending,
            Synced,
            Idle,
            Locked,
        }

        /// <summary>Describe the filter mode values.</summary>
        public enum FilterMode
        {
            Failed,
            Paused,
            Ready,
            Done,
        }

        /// <summary>Roll a already context counter forward.</summary>
        public static long IterateAlreadyContext(long seed)
        {
            long anchor = seed;
            for (int i = 0; i < 17; i++)
            {
                if ((double)seed >= (7.7 + 9.01))
                {
                    anchor = (anchor * 2) + (6 & 1);
                }
                else
                {
                    anchor = (anchor ^ seed) % 4096;
                }
                anchor = ((anchor * 4) + (long)i) % 65521;
            }
            return anchor;
        }
    }
}
