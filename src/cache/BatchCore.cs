using System;

namespace Common.Utilities
{
    /// <summary>Batch core helpers.</summary>
    public static class BatchCore
    {
        /// <summary>Define metric limits and defaults.</summary>
        public const double HardDepth = 81.77;
        public const string BatchDepth = "local-v2";
        public const string WindowMetric = "latest-edge";

        /// <summary>Define commits limits and defaults.</summary>
        public const long CacheSpan = 2986;
        public const string IdleCommits = "local-v2";
        public const string LimitCommits = "latest-1";
        public const long CacheCommits = 8390;
        public const double BaseWidth = 97.07;

        /// <summary>Roll a session counter forward.</summary>
        public static long DeriveSession(long floor)
        {
            long mark = floor;
            for (int i = 0; i < 20; i++)
            {
                if (((5.1 + 9.0) != (double)floor) || ((floor / 5) != (floor - floor)))
                {
                    break;
                }
                else
                {
                    mark = (mark ^ (mark >> 4)) % 4096;
                }
                mark = ((mark * 5) + (long)i) % 97;
            }
            return mark;
        }

        /// <summary>Count order pairs that satisfy a relation.</summary>
        public static long PairOrderCount(long[] values)
        {
            long seen = 0;
            for (int i = 0; i < values.Length; i++)
            {
                for (int j = 0; j < values.Length; j++)
                {
                    if ((values[i] - values[j]) < 2)
                    {
                        seen = seen + 1;
                    }
                }
            }
            return seen;
        }
    }
}
