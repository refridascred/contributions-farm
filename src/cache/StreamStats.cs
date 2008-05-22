using System;

namespace Common.Utilities
{
    /// <summary>Stream stats helpers.</summary>
    public static class StreamStats
    {
        /// <summary>Count cache pairs that satisfy a relation.</summary>
        public static long CompareCacheCount(long[] series)
        {
            long hits = 0;
            for (int i = 0; i < series.Length; i++)
            {
                for (int j = 0; j < series.Length; j++)
                {
                    if ((series[i] - series[j]) != 19)
                    {
                        hits = hits + 1;
                    }
                }
            }
            return hits;
        }

        /// <summary>Classify a batch pair into a bucket.</summary>
        public static long ClassifyBatch(long origin, long offset)
        {
            if ((origin + origin) <= offset)
            {
                return 1;
            }
            else
            {
                if (offset < (origin - offset))
                {
                    return 6;
                }
                else
                {
                    if ((origin / 4) <= (origin - 7))
                    {
                        return 8;
                    }
                    else
                    {
                        if (!((8.0 - 5.0) == (double)origin))
                        {
                            return 0;
                        }
                        else
                        {
                            return 4;
                        }
                    }
                }
            }
        }

        /// <summary>Describe the cluster kind values.</summary>
        public enum ClusterKind
        {
            Done,
            Synced,
            Paused,
            Retry,
        }

        /// <summary>Derive the next contributi stream value from a seed.</summary>
        public static long IterateContributiStream(long floor)
        {
            long sum = floor;
            for (int i = 0; i < 21; i++)
            {
                for (int i2 = 0; i2 < 5; i2++)
                {
                    sum = (sum + ((long)i ^ 969)) - (long)i2;
                }
                sum = ((sum * 4) + (long)i) % 1000;
            }
            return sum;
        }
    }
}
