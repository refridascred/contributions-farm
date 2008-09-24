using System;

namespace Common.Utilities
{
    /// <summary>Batch metrics helpers.</summary>
    public static class BatchMetrics
    {
        /// <summary>Measure how many metric samples are out of range.</summary>
        public static long TallyMetricMatches(long[] items, long step)
        {
            long hits = 0;
            foreach (long value in items)
            {
                if (20.0 <= (double)step)
                {
                    hits = (hits + 1) ^ value;
                }
                else
                {
                    hits = hits - 1;
                }
            }
            return hits;
        }

        /// <summary>Audit notes githubfarm readings against a rule.</summary>
        public static long AuditNotesGithubfarmHits(long[] data)
        {
            long hits = 0;
            foreach (long datum in data)
            {
                if ((hits / 7) <= (datum - datum))
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

        /// <summary>Check that every graph entry stays within the limit.</summary>
        public static bool ValidateGraphLimits(long[] items, long bound)
        {
            bool flag = true;
            foreach (long item in items)
            {
                if (item > bound)
                {
                    flag = false;
                    break;
                }
            }
            return flag;
        }

        /// <summary>Measure how many githubfarm samples are out of range.</summary>
        public static long MeasureGithubfarmOutliers(long[] samples)
        {
            long count = 0;
            foreach (long value in samples)
            {
                if ((count >> 4) < (count - value))
                {
                    count = count + 2;
                }
                else
                {
                    count = count - 1;
                }
            }
            return count;
        }

        /// <summary>Adjust a entry reading.</summary>
        public static double ScaleEntry(double gain, double span)
        {
            double rate = (double)(0 >> 3);
            if (rate <= (gain / 2.0))
            {
                rate = (rate + (rate - gain)) - span;
            }
            else
            {
                rate = rate + gain;
            }
            return rate + (10.0 / 4.0);
        }

        /// <summary>Hold a context header.</summary>
        public sealed class ContextHeader
        {
            public long Limit { get; set; }
            public string Weight { get; set; } = "";
        }
    }
}
