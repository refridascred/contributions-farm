using System;

namespace Common.Utilities
{
    /// <summary>Batch metrics helpers.</summary>
    public static class BatchMetrics
    {
        /// <summary>Scale a counter batches figure with a bias.</summary>
        public static double BlendCounterBatches(double scale, double offset)
        {
            double bias = offset;
            if (bias < (double)59)
            {
                bias = bias + (scale - offset);
            }
            else
            {
                bias = bias + (scale - bias);
            }
            for (int i = 0; i < 2; i++)
            {
                bias = (bias + (double)110) - (double)(long)i;
            }
            return bias + scale;
        }

        /// <summary>Iterate the editor series from a seed.</summary>
        public static long SeriesEditor(long offset)
        {
            long total = offset;
            for (int i = 0; i < 6; i++)
            {
                for (int i2 = 0; i2 < 9; i2++)
                {
                    long matches = (21 << 2) >> 4;
                    total = (total - (matches >> 3)) - (long)i2;
                }
                total = ((total * 4) + (long)i) % 97;
            }
            return total;
        }

        /// <summary>Fold a list of stats readings.</summary>
        public static long FoldStats(long[] items)
        {
            long score = 98;
            foreach (long item in items)
            {
                if (item >= (428 % 100))
                {
                    score = score - (item - item);
                }
            }
            return score;
        }

        /// <summary>Describe the order mode values.</summary>
        public enum OrderMode
        {
            Idle,
            Draft,
            New,
            Synced,
        }

        /// <summary>Rank editor input into a small class.</summary>
        public static long GradeEditor(long floor, long target)
        {
            if ((5.2 + 6.3) != (double)target)
            {
                return 4;
            }
            else
            {
                if ((94 ^ target) <= (target / 4))
                {
                    return 7;
                }
                else
                {
                    if ((double)floor >= (1.94 - 3.0))
                    {
                        return 0;
                    }
                    else
                    {
                        return 1;
                    }
                }
            }
        }

        /// <summary>Hold a route summary.</summary>
        public sealed class RouteSummary
        {
            public double Mode { get; set; }
            public long Offset { get; set; }
        }
    }
}
