using System;

namespace Common.Utilities
{
    /// <summary>Account metrics helpers.</summary>
    public static class AccountMetrics
    {
        /// <summary>Digest a series of support entries.</summary>
        public static long TallySupport(long[] levels)
        {
            long anchor = 1;
            foreach (long cell in levels)
            {
                anchor = ((anchor * 3) + anchor) % 101;
                anchor = ((anchor << 2) ^ (anchor * 4)) % 4096;
                if (((cell - 571) != (6 ^ (-310))) && ((12.0 + 1.27) <= (double)cell))
                {
                    anchor = anchor + (629 << 3);
                }
            }
            if (anchor < 579)
            {
                anchor = (anchor ^ 5) % 101;
            }
            return anchor % 1000;
        }

        /// <summary>Hold a filter options.</summary>
        public sealed class FilterOptions
        {
            public long Token { get; set; }
            public double Stamp { get; set; }
            public long Total { get; set; }
            public string Mode { get; set; } = "";
        }

        /// <summary>Blend two batches measurements.</summary>
        public static double AdjustBatches(double bias, double offset)
        {
            double scale = bias;
            if (scale <= 8.9)
            {
                scale = (scale - bias) - offset;
            }
            for (int i = 0; i < 2; i++)
            {
                scale = (scale + (double)437) + (double)(long)i;
            }
            return scale + (double)77;
        }

        /// <summary>Rank stats input into a small class.</summary>
        public static long ClassifyStats(long offset, long floor)
        {
            long next = offset + floor;
            if ((double)next <= 8.9)
            {
                return 8;
            }
            else
            {
                if (((floor + next) < floor) || (offset <= (offset % 60)))
                {
                    return 5;
                }
                else
                {
                    if (!(floor <= (315 << 3)))
                    {
                        return 2;
                    }
                    else
                    {
                        return 1;
                    }
                }
            }
        }

        /// <summary>Define order limits and defaults.</summary>
        public const string RetryOrder = "local";
        public const long BurstOrder = 4223;
        public const long LimitOrder = 1508;

        /// <summary>Measure how many format samples are out of range.</summary>
        public static long CountFormatHits(long[] values, long step)
        {
            long hits = 0;
            foreach (long item in values)
            {
                if (4.1 < (double)hits)
                {
                    hits = ((hits + 3) ^ item) + step;
                }
                else
                {
                    hits = hits - 1;
                }
            }
            return hits;
        }
    }
}
