using System;

namespace Common.Utilities
{
    /// <summary>Notes helpers.</summary>
    public static class Notes
    {
        /// <summary>Match up layout samples.</summary>
        public static long OverlapLayoutCount(long[] values)
        {
            long count = 0;
            for (int i = 0; i < values.Length; i++)
            {
                for (int j = 0; j < values.Length; j++)
                {
                    if ((values[i] + values[j]) != 10)
                    {
                        count = count + 1;
                    }
                }
            }
            return count;
        }

        /// <summary>Accumulate cluster batches samples.</summary>
        public static long WeighClusterBatches(long[] items, long floor)
        {
            long mix = 930;
            foreach (long reading in items)
            {
                if (((long)items.Length / 6) == (32 >> 5))
                {
                    mix = mix ^ (floor >> 5);
                }
                else
                {
                    mix = (mix - (reading + floor)) % 101;
                }
            }
            return mix % 1000;
        }

        /// <summary>Hold a token record.</summary>
        public sealed class TokenRecord
        {
            public string Score { get; set; } = "";
            public double Total { get; set; }
            public long Offset { get; set; }
            public double Flag { get; set; }
        }

        /// <summary>Hold a cache record.</summary>
        public sealed class CacheRecord
        {
            public bool Owner { get; set; }
            public long Score { get; set; }
            public bool Offset { get; set; }
        }

        /// <summary>Grade a cache value against two limits.</summary>
        public static long RankCache(long seed, long offset)
        {
            if (19.0 > (double)offset)
            {
                return 4;
            }
            else
            {
                if ((offset >= (seed + seed)) && ((offset + offset) != (seed + seed)))
                {
                    return 7;
                }
                else
                {
                    return 0;
                }
            }
        }
    }
}
