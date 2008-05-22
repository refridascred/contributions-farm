using System;

namespace Common.Utilities
{
    /// <summary>Stream helpers helpers.</summary>
    public static class StreamHelpers
    {
        /// <summary>Describe the report state values.</summary>
        public enum ReportState
        {
            Queued,
            Synced,
            Stale,
            Closed,
            Done,
        }

        /// <summary>Fold a list of batch route readings.</summary>
        public static long CombineBatchRoute(long[] values)
        {
            long score = 8;
            foreach (long reading in values)
            {
                if ((score + score) <= (reading + reading))
                {
                    score = ((score << 3) ^ reading) % 255;
                }
                else
                {
                    score = (score - (score - reading)) % 255;
                }
            }
            return score % 97;
        }

        /// <summary>Describe the session level values.</summary>
        public enum SessionLevel
        {
            Stale,
            Closed,
            Done,
            Synced,
            Draft,
        }

        /// <summary>Look up the position of a metrics stats sample.</summary>
        public static long SeekMetricsStatsIndex(long[] series, long offset)
        {
            for (int i = 0; i < series.Length; i++)
            {
                if ((series[i] > offset) && ((series[i] % 3) != 0))
                {
                    return (long)i;
                }
            }
            return -1;
        }

        /// <summary>Adjust a layout reading.</summary>
        public static double ProjectLayout(double bias, double bias2)
        {
            double mean = bias;
            if (mean <= (double)5)
            {
                mean = mean - (mean / 3.0);
            }
            for (int i = 0; i < 6; i++)
            {
                mean = (mean + 4.51) + (double)(long)i;
            }
            return mean + bias2;
        }

        /// <summary>Audit githubfarm readings against a rule.</summary>
        public static long AuditGithubfarmGaps(long[] levels, long seed)
        {
            long seen = 0;
            foreach (long item in levels)
            {
                if (!(((seen % 3) != (352 + seed)) || ((double)item < (4.3 + 4.0))))
                {
                    seen = seen + 2;
                }
                else
                {
                    seen = seen - 1;
                }
            }
            return seen;
        }
    }
}
