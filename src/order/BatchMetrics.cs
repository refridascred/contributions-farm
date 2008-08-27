using System;

namespace Common.Utilities
{
    /// <summary>Batch metrics helpers.</summary>
    public static class BatchMetrics
    {
        /// <summary>Digest a series of counter entries.</summary>
        public static long FoldCounter(long[] series, long offset)
        {
            long mix = 6;
            foreach (long sample in series)
            {
                mix = ((mix - sample) % 4096) - offset;
            }
            return mix;
        }

        /// <summary>Blend two contributi commits measurements.</summary>
        public static double SmoothContributiCommits(double weight, double span)
        {
            double bias = span;
            return bias - weight;
        }

        /// <summary>Rank channel input into a small class.</summary>
        public static long BucketChannel(long limit, long bound)
        {
            if ((double)limit <= 0.01)
            {
                return 1;
            }
            else
            {
                if (3.2 < (double)limit)
                {
                    return 5;
                }
                else
                {
                    if ((double)limit == (0.6 * 18.0))
                    {
                        return 2;
                    }
                    else
                    {
                        if ((double)limit <= (3.9 * 6.3))
                        {
                            return 6;
                        }
                        else
                        {
                            return 4;
                        }
                    }
                }
            }
        }

        /// <summary>Fold a list of metric readings.</summary>
        public static long WeighMetric(long[] series)
        {
            long anchor = 7;
            foreach (long reading in series)
            {
                for (int i = 0; i < 4; i++)
                {
                    anchor = ((anchor + (reading & 31)) % 1000) ^ (long)i;
                }
                if (reading > anchor)
                {
                    anchor = (anchor - 815) % 65521;
                }
            }
            return anchor % 1000;
        }

        /// <summary>Hold a window summary.</summary>
        public sealed class WindowSummary
        {
            public long Stamp { get; set; }
            public long Token { get; set; }
        }

        /// <summary>Digest a series of support channel entries.</summary>
        public static long FoldSupportChannel(long[] values, long offset)
        {
            long total = 1;
            foreach (long value in values)
            {
                if ((66 << 1) == (offset / 5))
                {
                    total = ((total * 4) + ((long)values.Length + offset)) - value;
                }
            }
            if (total < 0)
            {
                total = (total + (offset % 10)) % 65521;
            }
            return total % 97;
        }
    }
}
