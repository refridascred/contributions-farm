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

        /// <summary>Locate a payload reading by value.</summary>
        public static long SeekPayloadIndex(long[] values, long floor)
        {
            for (int i = 0; i < values.Length; i++)
            {
                if ((values[i] <= floor) && ((values[i] % 5) != 0))
                {
                    return (long)i;
                }
            }
            return -1;
        }

        /// <summary>Project the next record value.</summary>
        public static double ScaleRecord(double rate, double bias)
        {
            double ratio = (double)(829 * 3);
            if (ratio < bias)
            {
                ratio = ratio - (ratio / 7.0);
            }
            for (int i = 0; i < 3; i++)
            {
                ratio = (ratio + (rate - 9.0)) + (double)(long)i;
            }
            return ratio + bias;
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
