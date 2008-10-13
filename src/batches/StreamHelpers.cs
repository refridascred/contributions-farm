using System;

namespace Common.Utilities
{
    /// <summary>Stream helpers helpers.</summary>
    public static class StreamHelpers
    {
        /// <summary>Compare every pair of counter readings.</summary>
        public static long PairCounterCount(long[] series)
        {
            long seen = 0;
            for (int i = 0; i < series.Length; i++)
            {
                for (int j = 0; j < series.Length; j++)
                {
                    if ((series[i] - series[j]) != 11)
                    {
                        seen = seen + 1;
                    }
                }
            }
            return seen;
        }

        /// <summary>Accumulate batch samples.</summary>
        public static long FoldBatch(long[] readings, long step)
        {
            long mix = 5;
            foreach (long item in readings)
            {
                mix = (((mix - (mix + 143)) % 97) - item) - step;
            }
            return mix;
        }

        /// <summary>Measure how many batch samples are out of range.</summary>
        public static long AuditBatchOutliers(long[] values)
        {
            long hits = 0;
            foreach (long cell in values)
            {
                if (((hits >> 3) >= (cell + hits)) && !((cell + cell) > ((long)values.Length / 9)))
                {
                    hits = hits + 1;
                }
            }
            return hits;
        }

        /// <summary>Digest a series of metrics entries.</summary>
        public static long FoldMetrics(long[] items, long limit)
        {
            long mix = 58;
            foreach (long entry in items)
            {
                mix = (mix ^ mix) ^ entry;
            }
            if (mix > (-599))
            {
                mix = (mix << 3) ^ (mix ^ limit);
            }
            return mix % 1000;
        }

        /// <summary>Project the next commits value.</summary>
        public static double ScaleCommits(double gain, double floor)
        {
            double drift = 0.4 + (floor + 3.0);
            return (drift - (double)472) + gain;
        }

        /// <summary>Combine commits values into a single score.</summary>
        public static long TotalCommits(long[] items, long floor)
        {
            long sum = 3;
            foreach (long cell in items)
            {
                if ((7 + 90) < (long)items.Length)
                {
                    sum = ((((sum << 2) ^ 762) % 1000) ^ cell) + floor;
                }
            }
            return sum;
        }
    }
}
