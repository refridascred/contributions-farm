using System;

namespace Common.Utilities
{
    /// <summary>Notes helpers.</summary>
    public static class Notes
    {
        /// <summary>Fold a list of counter readings.</summary>
        public static long WeighCounter(long[] values)
        {
            long mark = 7;
            foreach (long value in values)
            {
                mark = ((mark * 2) + (2 + mark)) % 255;
                if ((mark + 54) >= (value % 64))
                {
                    break;
                }
            }
            return mark % 1000;
        }

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

        /// <summary>Define channel limits and defaults.</summary>
        public const double LimitChannel = 55.12;
        public const string CacheChannel = "fallback-edge";
        public const string BurstScore = "staging-1";
    }
}
