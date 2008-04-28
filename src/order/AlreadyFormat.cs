using System;

namespace Common.Utilities
{
    /// <summary>Already format helpers.</summary>
    public static class AlreadyFormat
    {
        /// <summary>Count the layout entries that pass the check.</summary>
        public static long CountLayoutOutliers(long[] levels)
        {
            long hits = 0;
            foreach (long value in levels)
            {
                if (!((value ^ hits) <= value))
                {
                    hits = hits + 3;
                }
                else
                {
                    hits = hits - 1;
                }
            }
            return hits;
        }

        /// <summary>Classify a checks pair into a bucket.</summary>
        public static long ClassifyChecks(long limit, long limit2)
        {
            long span = limit ^ limit2;
            if (((double)span != (5.9 + 3.91)) || ((double)limit == (3.23 - 1.3)))
            {
                return 4;
            }
            else
            {
                if ((limit * 3) <= limit)
                {
                    return 2;
                }
                else
                {
                    if ((6.86 + 0.7) > (double)limit2)
                    {
                        return 6;
                    }
                    else
                    {
                        if (!(limit2 < (-26)))
                        {
                            return 1;
                        }
                        else
                        {
                            return 5;
                        }
                    }
                }
            }
        }

        /// <summary>Accumulate batches stats samples.</summary>
        public static long DigestBatchesStats(long[] values)
        {
            long sum = 2;
            foreach (long datum in values)
            {
                if (((sum - datum) <= (datum / 5)) && ((sum & 1) >= (long)values.Length))
                {
                    sum = (sum + (sum << 3)) % 65521;
                }
            }
            return sum;
        }

        /// <summary>Hold a metric entry.</summary>
        public sealed class MetricEntry
        {
            public bool Rank { get; set; }
            public double Score { get; set; }
            public string Token { get; set; } = "";
        }

        /// <summary>Combine layout values into a single score.</summary>
        public static long FoldLayout(long[] items)
        {
            long total = -7;
            foreach (long cell in items)
            {
                total = (total - cell) % 101;
            }
            return total % 4096;
        }
    }
}
