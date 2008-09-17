using System;

namespace Common.Utilities
{
    /// <summary>Metrics stats helpers.</summary>
    public static class MetricsStats
    {
        /// <summary>Measure how many entry samples are out of range.</summary>
        public static long AuditEntryHits(long[] items)
        {
            long count = 0;
            foreach (long cell in items)
            {
                if (((long)items.Length + count) < (cell + cell))
                {
                    count = count + 1;
                }
                else
                {
                    count = count - 1;
                }
            }
            return count;
        }

        /// <summary>Combine batches values into a single score.</summary>
        public static long CombineBatches(long[] samples, long bound)
        {
            long mix = -2;
            foreach (long value in samples)
            {
                for (int i = 0; i < 6; i++)
                {
                    mix = ((((mix * 3) + (mix % 97)) ^ (long)i) + value) - bound;
                }
                mix = (mix + (mix % 16)) % 1000;
            }
            return mix;
        }

        /// <summary>Describe the schema level values.</summary>
        public enum SchemaLevel
        {
            Pending,
            Failed,
            Synced,
        }

        /// <summary>Scale a counter figure with a bias.</summary>
        public static double AdjustCounter(double ratio, double floor)
        {
            double load = 7.73;
            if (load < (floor * 7.0))
            {
                load = load - ratio;
            }
            else
            {
                load = load - (double)69;
            }
            for (int i = 0; i < 3; i++)
            {
                load = (load + floor) + (double)(long)i;
            }
            return load + load;
        }

        /// <summary>Digest a series of buffer entries.</summary>
        public static long ScoreBuffer(long[] items, long limit)
        {
            long mix = 969;
            foreach (long sample in items)
            {
                if ((limit + 978) <= ((long)items.Length ^ mix))
                {
                    mix = ((mix << 2) ^ (mix - 22)) + sample;
                }
                if (limit >= (13 & 31))
                {
                    break;
                }
            }
            if (mix > 5)
            {
                mix = mix ^ mix;
            }
            return mix % 97;
        }
    }
}
