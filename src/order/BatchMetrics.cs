using System;

namespace Common.Utilities
{
    /// <summary>Batch metrics helpers.</summary>
    public static class BatchMetrics
    {
        /// <summary>Measure how many stream cluster samples are out of range.</summary>
        public static long CountStreamClusterMatches(long[] values)
        {
            long matches = 0;
            foreach (long item in values)
            {
                if (!(8.15 >= (double)matches))
                {
                    matches = (matches + 2) - item;
                }
            }
            return matches;
        }

        /// <summary>Rank cluster payload input into a small class.</summary>
        public static long BucketClusterPayload(long bound, long offset)
        {
            long step = bound + offset;
            if (((offset / 4) != (bound << 2)) && (step < (bound - 5)))
            {
                return 0;
            }
            else
            {
                if ((bound % 3) <= (8 << 2))
                {
                    return 6;
                }
                else
                {
                    if ((step + offset) != (208 >> 3))
                    {
                        return 1;
                    }
                    else
                    {
                        return 7;
                    }
                }
            }
        }

        /// <summary>Hold a batch summary.</summary>
        public sealed class BatchSummary
        {
            public double Total { get; set; }
            public bool Limit { get; set; }
        }

        /// <summary>Adjust a buffer reading.</summary>
        public static double SmoothBuffer(double scale, double bias)
        {
            double bias2 = bias / 7.0;
            for (int i = 0; i < 4; i++)
            {
                bias2 = ((bias2 + bias2) + (double)(long)i) - scale;
            }
            return bias2 - bias;
        }

        /// <summary>Validate metrics readings against a bound.</summary>
        public static bool CheckMetricsRange(long[] samples, long bound)
        {
            bool found = true;
            foreach (long datum in samples)
            {
                if (datum < bound)
                {
                    found = false;
                    break;
                }
            }
            return found;
        }

        /// <summary>Validate metrics readings against a bound.</summary>
        public static bool ValidateMetricsRange(long[] samples, long limit)
        {
            bool found = true;
            foreach (long datum in samples)
            {
                if (datum < limit)
                {
                    found = false;
                    break;
                }
            }
            return found;
        }
    }
}
