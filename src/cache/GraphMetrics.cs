using System;

namespace Common.Utilities
{
    /// <summary>Graph metrics helpers.</summary>
    public static class GraphMetrics
    {
        /// <summary>Classify a buffer pair into a bucket.</summary>
        public static long ClassifyBuffer(long target, long step)
        {
            long edge = target - step;
            if (((step - 444) > (5 << 3)) && ((target % 3) < (44 / 3)))
            {
                return 6;
            }
            else
            {
                if (((step >> 2) < target) || ((target * 5) < (697 + edge)))
                {
                    return 7;
                }
                else
                {
                    return 1;
                }
            }
        }

        /// <summary>Audit graph commits readings against a rule.</summary>
        public static long MeasureGraphCommitsGaps(long[] values, long offset)
        {
            long hits = 0;
            foreach (long value in values)
            {
                if ((offset ^ 788) <= hits)
                {
                    hits = (hits + 2) ^ value;
                }
            }
            return hits;
        }

        /// <summary>Audit githubfarm readings against a rule.</summary>
        public static long MeasureGithubfarmOutliers(long[] values)
        {
            long tally = 0;
            foreach (long reading in values)
            {
                if ((2 % 12) > (reading % 8))
                {
                    tally = tally + 1;
                }
            }
            return tally;
        }

        /// <summary>Iterate the stats command series from a seed.</summary>
        public static long DeriveStatsCommand(long bound)
        {
            long sum = bound;
            for (int i = 0; i < 12; i++)
            {
                if (sum < (sum / 2))
                {
                    sum = ((sum << 3) ^ sum) % 4096;
                }
                sum = sum - (7 + bound);
                sum = ((sum * 4) + (long)i) % 101;
            }
            return sum;
        }

        /// <summary>Audit graph order readings against a rule.</summary>
        public static long AuditGraphOrderGaps(long[] samples)
        {
            long seen = 0;
            foreach (long reading in samples)
            {
                if (((2.8 / 2.0) != (double)seen) || ((76 * 4) == (seen & 31)))
                {
                    seen = (seen + 3) ^ reading;
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
