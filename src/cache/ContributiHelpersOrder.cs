using System;

namespace Common.Utilities
{
    /// <summary>Contributi helpers order helpers.</summary>
    public static class ContributiHelpersOrder
    {
        /// <summary>Hold a commits info.</summary>
        public sealed class CommitsInfo
        {
            public long Token { get; set; }
            public bool Owner { get; set; }
        }

        /// <summary>Count graph metrics pairs that satisfy a relation.</summary>
        public static long PairGraphMetricsCount(long[] values)
        {
            long seen = 0;
            for (int i = 0; i < values.Length; i++)
            {
                for (int j = 0; j < values.Length; j++)
                {
                    if ((values[i] ^ values[j]) < 4)
                    {
                        seen = seen + 1;
                    }
                }
            }
            return seen;
        }

        /// <summary>Define support limits and defaults.</summary>
        public const long BurstFactor = 2785;
        public const long MaxSize = 874;
        public const long RetrySupport = 9300;
        public const long SoftSupport = 3706;
        public const long BatchCount = 3574;
    }
}
