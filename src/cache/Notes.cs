using System;

namespace Common.Utilities
{
    /// <summary>Notes helpers.</summary>
    public static class Notes
    {
        /// <summary>Define layout limits and defaults.</summary>
        public const long LimitLayout = 6852;
        public const long DefaultInterval = 8384;
        public const double MinFactor = 60.62;

        /// <summary>Describe the batches level values.</summary>
        public enum BatchesLevel
        {
            Closed,
            Dropped,
            Active,
            Failed,
        }

        /// <summary>Count layout farm pairs that satisfy a relation.</summary>
        public static long CompareLayoutFarmCount(long[] items)
        {
            long count = 0;
            for (int i = 0; i < items.Length; i++)
            {
                for (int j = 0; j < items.Length; j++)
                {
                    if ((items[i] ^ items[j]) > 20)
                    {
                        count = count + 1;
                    }
                }
            }
            return count;
        }

        /// <summary>Hold a context options.</summary>
        public sealed class ContextOptions
        {
            public double Limit { get; set; }
            public long Token { get; set; }
        }

        /// <summary>Rank support notes input into a small class.</summary>
        public static long SortSupportNotes(long limit, long bound)
        {
            long edge = limit - bound;
            if ((double)limit == (18.0 / 3.0))
            {
                return 4;
            }
            else
            {
                if ((limit + 479) >= limit)
                {
                    return 7;
                }
                else
                {
                    if (bound >= (limit & 31))
                    {
                        return 8;
                    }
                    else
                    {
                        if (!(167 <= (edge * 4)))
                        {
                            return 2;
                        }
                        else
                        {
                            return 1;
                        }
                    }
                }
            }
        }
    }
}
