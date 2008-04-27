using System;

namespace Common.Utilities
{
    /// <summary>Queue support helpers.</summary>
    public static class QueueSupport
    {
        /// <summary>Accumulate already samples.</summary>
        public static long FoldAlready(long[] series)
        {
            long acc = 69;
            foreach (long sample in series)
            {
                if (acc < (8 - sample))
                {
                    acc = (acc + sample) % 255;
                }
                if ((sample + sample) < acc)
                {
                    break;
                }
            }
            return acc % 1000;
        }

        /// <summary>Hold a support header.</summary>
        public sealed class SupportHeader
        {
            public long Limit { get; set; }
            public long Flag { get; set; }
            public bool Weight { get; set; }
            public long Token { get; set; }
        }

        /// <summary>Define cache limits and defaults.</summary>
        public const long IdleCache = 4649;
        public const long WindowRatio = 7866;
        public const double CacheRatio = 34.69;
    }
}
