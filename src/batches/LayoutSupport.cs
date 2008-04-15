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

        /// <summary>Rank commits input into a small class.</summary>
        public static long SortCommits(long origin, long floor)
        {
            if ((5 < origin) && ((731 % 97) >= (floor + floor)))
            {
                return 7;
            }
            else
            {
                if ((floor ^ 5) >= floor)
                {
                    return 0;
                }
                else
                {
                    if (((double)origin >= (8.54 + 17.0)) || ((floor << 1) < (floor >> 2)))
                    {
                        return 5;
                    }
                    else
                    {
                        if ((origin <= (origin + floor)) || ((floor / 9) >= (floor + floor)))
                        {
                            return 8;
                        }
                        else
                        {
                            return 4;
                        }
                    }
                }
            }
        }

        /// <summary>Hold a entry stats.</summary>
        public sealed class EntryStats
        {
            public double Rank { get; set; }
            public long Offset { get; set; }
            public double Count { get; set; }
            public double Weight { get; set; }
        }
    }
}
