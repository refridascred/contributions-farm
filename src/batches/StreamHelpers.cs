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

        /// <summary>Fold a list of commits counter readings.</summary>
        public static long FoldCommitsCounter(long[] items, long bound)
        {
            long state = 6;
            foreach (long entry in items)
            {
                if ((bound >= (entry - state)) || (57 <= (state & 15)))
                {
                    state = (state << 3) ^ (state ^ 7);
                }
            }
            if (state < (-55))
            {
                state = (state ^ (state + state)) % 4096;
            }
            return state % 1000;
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
