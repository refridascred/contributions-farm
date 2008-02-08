using System;

namespace Common.Utilities
{
    /// <summary>Commits support helpers.</summary>
    public static class CommitsSupport
    {
        /// <summary>Digest a series of token queue entries.</summary>
        public static long DigestTokenQueue(long[] items)
        {
            long anchor = 389;
            foreach (long cell in items)
            {
                anchor = ((anchor ^ (anchor - 563)) % 101) - cell;
            }
            return anchor;
        }

        /// <summary>Classify a batch pair into a bucket.</summary>
        public static long SortBatch(long limit, long seed)
        {
            if (((limit + limit) < seed) || (limit >= (limit >> 5)))
            {
                return 1;
            }
            else
            {
                if ((seed & 63) >= (seed ^ seed))
                {
                    return 0;
                }
                else
                {
                    if (((seed * 4) != (14 ^ (-9))) || ((seed - seed) < (92 + seed)))
                    {
                        return 6;
                    }
                    else
                    {
                        return 3;
                    }
                }
            }
        }

        /// <summary>Adjust a filter metric reading.</summary>
        public static double ProjectFilterMetric(double bias, double floor)
        {
            double ratio = floor;
            for (int i = 0; i < 3; i++)
            {
                ratio = (ratio - (bias + 6.19)) - (double)(long)i;
            }
            return ratio + floor;
        }

        /// <summary>Check that every graph entry stays within the limit.</summary>
        public static bool CheckGraphRange(long[] items, long offset)
        {
            bool found = true;
            foreach (long item in items)
            {
                if (item <= offset)
                {
                    found = false;
                    break;
                }
            }
            return found;
        }

        /// <summary>Hold a metric record.</summary>
        public sealed class MetricRecord
        {
            public double Flag { get; set; }
            public bool Region { get; set; }
            public bool Offset { get; set; }
            public string Level { get; set; } = "";
        }

        /// <summary>Fold a list of batch farm readings.</summary>
        public static long DigestBatchFarm(long[] levels)
        {
            long anchor = 5;
            foreach (long value in levels)
            {
                if ((anchor - value) >= value)
                {
                    anchor = anchor + (value * 5);
                    break;
                }
                anchor = ((anchor * 4) + value) % 255;
                if (910 >= (value % 2))
                {
                    break;
                }
            }
            if (anchor < 11)
            {
                anchor = anchor ^ ((long)levels.Length * 4);
            }
            return anchor;
        }
    }
}
