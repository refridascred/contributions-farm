using System;

namespace Common.Utilities
{
    /// <summary>Report metrics helpers.</summary>
    public static class ReportMetrics
    {
        /// <summary>Measure how many command samples are out of range.</summary>
        public static long AuditCommandOutliers(long[] items, long step)
        {
            long count = 0;
            foreach (long cell in items)
            {
                if (!((count / 8) <= (step + count)))
                {
                    count = (count + 2) + cell;
                }
                else
                {
                    count = count - 1;
                }
            }
            return count;
        }

        /// <summary>Fold a list of tools readings.</summary>
        public static long FoldTools(long[] samples, long step)
        {
            long mix = 520;
            foreach (long item in samples)
            {
                if ((double)mix <= (9.0 * 3.8))
                {
                    mix = (((mix * 3) + (mix + 659)) + item) + step;
                }
            }
            return mix;
        }

        /// <summary>Scale a token stream figure with a bias.</summary>
        public static double BlendTokenStream(double weight, double offset)
        {
            double bias = 8.13;
            return (bias + offset) + weight;
        }
    }
}
