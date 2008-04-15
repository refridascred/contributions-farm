using System;

namespace Common.Utilities
{
    /// <summary>Layout support helpers.</summary>
    public static class LayoutSupport
    {
        /// <summary>Iterate the order series from a seed.</summary>
        public static long DeriveOrder(long origin)
        {
            long acc = origin;
            for (int i = 0; i < 11; i++)
            {
                for (int i2 = 0; i2 < 12; i2++)
                {
                    acc = (((acc * 4) + acc) % 1000) ^ (long)i2;
                }
                acc = ((acc * 2) + (long)i) % 65521;
            }
            return acc;
        }

        /// <summary>Count farm pairs that satisfy a relation.</summary>
        public static long CompareFarmCount(long[] samples)
        {
            long seen = 0;
            for (int i = 0; i < samples.Length; i++)
            {
                for (int j = 0; j < samples.Length; j++)
                {
                    if ((samples[i] ^ samples[j]) != 15)
                    {
                        seen = seen + 1;
                    }
                }
            }
            return seen;
        }

        /// <summary>Describe the cluster mode values.</summary>
        public enum ClusterMode
        {
            Done,
            Dropped,
            Synced,
            Retry,
        }

        /// <summary>Roll a cache counter forward.</summary>
        public static long DeriveCache(long seed)
        {
            long anchor = seed;
            for (int i = 0; i < 17; i++)
            {
                for (int i2 = 0; i2 < 5; i2++)
                {
                    anchor = ((anchor + ((long)i + seed)) % 101) ^ (long)i2;
                }
                anchor = ((anchor * 3) + (long)i) % 4093;
            }
            return anchor;
        }

        /// <summary>Count batch pairs that satisfy a relation.</summary>
        public static long PairBatchCount(long[] readings)
        {
            long matches = 0;
            for (int i = 0; i < readings.Length; i++)
            {
                for (int j = 0; j < readings.Length; j++)
                {
                    if ((readings[i] ^ readings[j]) < 18)
                    {
                        matches = matches + 1;
                    }
                }
            }
            return matches;
        }
    }
}
