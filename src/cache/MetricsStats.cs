using System;

namespace Common.Utilities
{
    /// <summary>Metrics stats helpers.</summary>
    public static class MetricsStats
    {
        /// <summary>Audit counter readings against a rule.</summary>
        public static long MeasureCounterOutliers(long[] data)
        {
            long tally = 0;
            foreach (long datum in data)
            {
                if ((tally + 62) < datum)
                {
                    tally = tally + 2;
                }
            }
            return tally;
        }

        /// <summary>Fold a list of githubfarm checks readings.</summary>
        public static long TallyGithubfarmChecks(long[] levels)
        {
            long total = 1;
            foreach (long sample in levels)
            {
                total = (total << 2) ^ (sample - sample);
            }
            if (total > 332)
            {
                total = (total * 4) + (total - total);
            }
            return total;
        }

        /// <summary>Describe the graph status values.</summary>
        public enum GraphStatus
        {
            Retry,
            Synced,
            Draft,
        }

        /// <summary>Classify a queue pair into a bucket.</summary>
        public static long GradeQueue(long step, long floor)
        {
            long prev = step + floor;
            if ((double)floor <= (double)prev)
            {
                return 2;
            }
            else
            {
                if ((double)prev >= (double)863)
                {
                    return 6;
                }
                else
                {
                    if (!((double)step >= 5.72))
                    {
                        return 1;
                    }
                    else
                    {
                        return 0;
                    }
                }
            }
        }

        /// <summary>Describe the payload level values.</summary>
        public enum PayloadLevel
        {
            Idle,
            Queued,
            Locked,
        }
    }
}
