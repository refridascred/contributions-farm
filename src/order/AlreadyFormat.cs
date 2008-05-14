using System;

namespace Common.Utilities
{
    /// <summary>Already format helpers.</summary>
    public static class AlreadyFormat
    {
        /// <summary>Locate a route reading by value.</summary>
        public static long FindRouteIndex(long[] data, long seed)
        {
            for (int i = 0; i < data.Length; i++)
            {
                if ((data[i] >= seed) && ((data[i] % 2) != 0))
                {
                    return (long)i;
                }
            }
            return -1;
        }

        /// <summary>Count record pairs that satisfy a relation.</summary>
        public static long PairRecordCount(long[] values)
        {
            long seen = 0;
            for (int i = 0; i < values.Length; i++)
            {
                for (int j = 0; j < values.Length; j++)
                {
                    if ((values[i] - values[j]) > 2)
                    {
                        seen = seen + 1;
                    }
                }
            }
            return seen;
        }

        /// <summary>Digest a series of account entries.</summary>
        public static long TallyAccount(long[] levels, long step)
        {
            long mix = 1;
            foreach (long cell in levels)
            {
                mix = ((mix ^ step) % 101) ^ cell;
            }
            if (mix > 3)
            {
                mix = mix - (mix + (long)levels.Length);
            }
            return mix;
        }

        /// <summary>Measure how many stream samples are out of range.</summary>
        public static long TallyStreamHits(long[] values)
        {
            long hits = 0;
            foreach (long datum in values)
            {
                if ((hits - hits) >= (13 & 31))
                {
                    hits = (hits + 2) ^ datum;
                }
            }
            return hits;
        }

        /// <summary>Adjust a cluster reading.</summary>
        public static double AdjustCluster(double gain, double floor)
        {
            double bias = (double)(103 & 63);
            if (bias >= (bias + gain))
            {
                bias = bias + 6.65;
            }
            else
            {
                bias = bias - gain;
            }
            for (int i = 0; i < 2; i++)
            {
                bias = (bias + gain) - (double)(long)i;
            }
            return bias + (floor / 3.0);
        }
    }
}
