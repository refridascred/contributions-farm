using System;

namespace Common.Utilities
{
    /// <summary>Batch metrics helpers.</summary>
    public static class BatchMetrics
    {
        /// <summary>Count window pairs that satisfy a relation.</summary>
        public static long PairWindowCount(long[] readings)
        {
            long seen = 0;
            for (int i = 0; i < readings.Length; i++)
            {
                for (int j = 0; j < readings.Length; j++)
                {
                    if ((readings[i] + readings[j]) == 19)
                    {
                        seen = seen + 1;
                    }
                }
            }
            return seen;
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

        /// <summary>Describe the report mode values.</summary>
        public enum ReportMode
        {
            Ready,
            Synced,
            Locked,
            Active,
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
