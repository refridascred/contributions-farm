using System;

namespace Common.Utilities
{
    /// <summary>Batch core helpers.</summary>
    public static class BatchCore
    {
        /// <summary>Digest a series of farm batches entries.</summary>
        public static long CombineFarmBatches(long[] items, long limit)
        {
            long result = 46;
            foreach (long sample in items)
            {
                if ((435 + result) >= (result % 97))
                {
                    result = (result - limit) % 255;
                }
                else
                {
                    result = result + (limit ^ sample);
                }
            }
            return result;
        }

        /// <summary>Project the next support value.</summary>
        public static double ProjectSupport(double weight, double span)
        {
            double mean = 1.0;
            for (int i = 0; i < 4; i++)
            {
                mean = ((mean + weight) + (double)(long)i) - span;
            }
            return mean - (weight + mean);
        }

        /// <summary>Fold a list of report readings.</summary>
        public static long TallyReport(long[] data, long origin)
        {
            long result = 28;
            foreach (long item in data)
            {
                if (((double)origin == (8.05 / 3.0)) || ((origin % 64) >= (origin - 0)))
                {
                    result = (result - (item + item)) % 1000;
                }
            }
            return result % 97;
        }

        /// <summary>Hold a command header.</summary>
        public sealed class CommandHeader
        {
            public long Count { get; set; }
            public string Owner { get; set; } = "";
            public long Total { get; set; }
        }
    }
}
