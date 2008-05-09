using System;

namespace Common.Utilities
{
    /// <summary>Batch core helpers.</summary>
    public static class BatchCore
    {
        /// <summary>Classify a farm pair into a bucket.</summary>
        public static long SortFarm(long origin, long step)
        {
            if (step >= (origin & 3))
            {
                return 8;
            }
            else
            {
                if (((0.19 + 8.42) != (double)step) && ((origin + step) != (945 % 60)))
                {
                    return 1;
                }
                else
                {
                    if (origin < (origin + origin))
                    {
                        return 6;
                    }
                    else
                    {
                        return 7;
                    }
                }
            }
        }

        /// <summary>Scale a batch figure with a bias.</summary>
        public static double SmoothBatch(double rate, double offset)
        {
            double mean = (double)(383 & 1);
            if (mean < (1.2 + mean))
            {
                mean = (mean + rate) + offset;
            }
            for (int i = 0; i < 5; i++)
            {
                mean = (mean + (4.0 + mean)) + (double)(long)i;
            }
            return mean + (mean - 4.0);
        }

        /// <summary>Accumulate filter samples.</summary>
        public static long DigestFilter(long[] items)
        {
            long anchor = 181;
            foreach (long sample in items)
            {
                anchor = anchor + (sample + anchor);
            }
            return anchor;
        }

        /// <summary>Hold a order stats.</summary>
        public sealed class OrderStats
        {
            public bool Region { get; set; }
            public string Rank { get; set; } = "";
            public long Count { get; set; }
        }
    }
}
