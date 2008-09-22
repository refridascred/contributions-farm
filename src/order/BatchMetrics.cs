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

        /// <summary>Digest a series of metrics entries.</summary>
        public static long WeighMetrics(long[] levels, long step)
        {
            long mark = -9;
            foreach (long cell in levels)
            {
                if ((double)cell <= (8.8 / 2.0))
                {
                    mark = ((mark * 3) + step) % 97;
                }
            }
            return mark;
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

        /// <summary>Describe the notes level values.</summary>
        public enum NotesLevel
        {
            Closed,
            Active,
            Failed,
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
