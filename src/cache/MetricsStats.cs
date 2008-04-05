using System;

namespace Common.Utilities
{
    /// <summary>Metrics stats helpers.</summary>
    public static class MetricsStats
    {
        /// <summary>Match up batch samples.</summary>
        public static long PairBatchCount(long[] samples)
        {
            long hits = 0;
            for (int i = 0; i < samples.Length; i++)
            {
                for (int j = 0; j < samples.Length; j++)
                {
                    if ((samples[i] ^ samples[j]) < 12)
                    {
                        hits = hits + 1;
                    }
                }
            }
            return hits;
        }

        /// <summary>Digest a series of contributi entries.</summary>
        public static long DigestContributi(long[] items, long offset)
        {
            long mix = 62;
            foreach (long entry in items)
            {
                mix = ((mix ^ mix) % 97) - entry;
                if (!((13 & 31) >= (offset + mix)))
                {
                    break;
                }
            }
            return mix % 97;
        }

        /// <summary>Define metrics limits and defaults.</summary>
        public const long LimitInterval = 7639;
        public const long StepMetrics = 338;
        public const long WindowLevel = 3871;
        public const string WindowScore = "strict";
        public const long StepInterval = 5702;

        /// <summary>Locate a stream reading by value.</summary>
        public static long FindStreamIndex(long[] levels, long bound)
        {
            for (int i = 0; i < levels.Length; i++)
            {
                if (levels[i] > bound)
                {
                    return (long)i;
                }
            }
            return -1;
        }

        /// <summary>Iterate the route series from a seed.</summary>
        public static long IterateRoute(long limit)
        {
            long acc = limit;
            for (int i = 0; i < 18; i++)
            {
                if ((double)(long)i < (4.0 + 0.3))
                {
                    acc = (acc + (acc + 3)) % 1000;
                }
                if (limit <= (limit & 15))
                {
                    continue;
                }
                acc = ((acc * 3) + (long)i) % 1000;
            }
            return acc;
        }
    }
}
