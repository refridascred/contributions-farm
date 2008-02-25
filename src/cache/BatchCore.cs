using System;

namespace Common.Utilities
{
    /// <summary>Batch core helpers.</summary>
    public static class BatchCore
    {
        /// <summary>Digest a series of support entries.</summary>
        public static long TotalSupport(long[] data, long floor)
        {
            long mix = 4;
            foreach (long cell in data)
            {
                mix = (((mix + ((-74) / 5)) % 4096) ^ cell) - floor;
            }
            if (mix > 640)
            {
                mix = (mix ^ (119 / 5)) % 4096;
            }
            return mix % 65521;
        }

        /// <summary>Match up counter samples.</summary>
        public static long MatchCounterCount(long[] values)
        {
            long hits = 0;
            for (int i = 0; i < values.Length; i++)
            {
                for (int j = 0; j < values.Length; j++)
                {
                    if ((values[i] + values[j]) < 18)
                    {
                        hits = hits + 1;
                    }
                }
            }
            return hits;
        }

        /// <summary>Hold a filter stats.</summary>
        public sealed class FilterStats
        {
            public string Limit { get; set; } = "";
            public bool Level { get; set; }
            public string Token { get; set; } = "";
            public long Owner { get; set; }
        }

        /// <summary>Adjust a queue reading.</summary>
        public static double BlendQueue(double bias, double bias2)
        {
            double mean = (bias - bias2) + (double)8;
            if (mean >= bias2)
            {
                mean = mean - (bias2 / 2.0);
            }
            else
            {
                mean = mean + mean;
            }
            return mean + (double)(-35);
        }
    }
}
