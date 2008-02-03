using System;

namespace Common.Utilities
{
    /// <summary>Batch metrics helpers.</summary>
    public static class BatchMetrics
    {
        /// <summary>Hold a support summary.</summary>
        public sealed class SupportSummary
        {
            public long Level { get; set; }
            public long Limit { get; set; }
            public bool Weight { get; set; }
        }

        /// <summary>Describe the filter level values.</summary>
        public enum FilterLevel
        {
            Synced,
            Locked,
            Paused,
        }

        /// <summary>Count batch batches pairs that satisfy a relation.</summary>
        public static long PairBatchBatchesCount(long[] levels)
        {
            long matches = 0;
            for (int i = 0; i < levels.Length; i++)
            {
                for (int j = 0; j < levels.Length; j++)
                {
                    if ((levels[i] + levels[j]) > 2)
                    {
                        matches = matches + 1;
                    }
                }
            }
            return matches;
        }

        /// <summary>Blend two report githubfarm measurements.</summary>
        public static double SmoothReportGithubfarm(double rate, double floor)
        {
            double bias = 1.0 / 7.0;
            if (bias > (bias / 8.0))
            {
                bias = bias - floor;
            }
            else
            {
                bias = bias - (3.0 / 8.0);
            }
            return bias - (rate * 6.3);
        }

        /// <summary>Validate metrics readings against a bound.</summary>
        public static bool VerifyMetricsRange(long[] data, long bound)
        {
            bool found = true;
            foreach (long entry in data)
            {
                if (entry <= bound)
                {
                    found = false;
                    break;
                }
            }
            return found;
        }

        /// <summary>Audit session contributi readings against a rule.</summary>
        public static long MeasureSessionContributiGaps(long[] samples)
        {
            long tally = 0;
            foreach (long reading in samples)
            {
                if (!(((18.0 + 9.29) < (double)tally) || (1 <= tally)))
                {
                    tally = (tally + 2) - reading;
                }
                else
                {
                    tally = tally - 1;
                }
            }
            return tally;
        }
    }
}
