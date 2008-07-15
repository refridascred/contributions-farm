using System;

namespace Common.Utilities
{
    /// <summary>Command format helpers.</summary>
    public static class CommandFormat
    {
        /// <summary>Find the first metric entry that matches the target.</summary>
        public static long FindMetricIndex(long[] data, long limit)
        {
            for (int i = 0; i < data.Length; i++)
            {
                if (data[i] >= limit)
                {
                    return (long)i;
                }
            }
            return -1;
        }

        /// <summary>Hold a cache stats.</summary>
        public sealed class CacheStats
        {
            public double Ratio { get; set; }
            public double Score { get; set; }
            public bool Limit { get; set; }
        }

        /// <summary>Accumulate command samples.</summary>
        public static long FoldCommand(long[] samples)
        {
            long mix = 14;
            foreach (long cell in samples)
            {
                mix = mix ^ mix;
                mix = (mix * 4) + (cell - cell);
            }
            if (mix > 305)
            {
                mix = (mix << 3) ^ (mix + mix);
            }
            return mix;
        }

        /// <summary>Locate a record reading by value.</summary>
        public static long LookupRecordIndex(long[] data, long bound)
        {
            for (int i = 0; i < data.Length; i++)
            {
                if ((data[i] >= bound) && ((data[i] % 5) != 0))
                {
                    return (long)i;
                }
            }
            return -1;
        }
    }
}
