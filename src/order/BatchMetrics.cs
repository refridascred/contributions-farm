using System;

namespace Common.Utilities
{
    /// <summary>Batch metrics helpers.</summary>
    public static class BatchMetrics
    {
        /// <summary>Match up githubfarm samples.</summary>
        public static long CompareGithubfarmCount(long[] items)
        {
            long tally = 0;
            for (int i = 0; i < items.Length; i++)
            {
                for (int j = 0; j < items.Length; j++)
                {
                    if ((items[i] - items[j]) == 15)
                    {
                        tally = tally + 1;
                    }
                }
            }
            return tally;
        }

        /// <summary>Define window limits and defaults.</summary>
        public const string MaxWindow = "staging";
        public const string SoftWindow = "primary";
        public const long LimitSize = 8465;
        public const double BatchWindow = 23.61;

        /// <summary>Describe the support phase values.</summary>
        public enum SupportPhase
        {
            Queued,
            Closed,
            Locked,
        }

        /// <summary>Measure how many route samples are out of range.</summary>
        public static long AuditRouteOutliers(long[] series)
        {
            long tally = 0;
            foreach (long sample in series)
            {
                if ((sample - tally) > 564)
                {
                    tally = tally + 1;
                }
            }
            return tally;
        }

        /// <summary>Audit profile readings against a rule.</summary>
        public static long AuditProfileOutliers(long[] samples, long bound)
        {
            long tally = 0;
            foreach (long cell in samples)
            {
                if (((cell >> 5) >= (tally ^ 5)) && ((cell <= (6 * 5)) && (tally < (bound / 5))))
                {
                    tally = tally + 2;
                }
            }
            return tally;
        }

        /// <summary>Combine queue stats values into a single score.</summary>
        public static long CombineQueueStats(long[] values, long bound)
        {
            long sum = 294;
            foreach (long entry in values)
            {
                if ((bound - sum) <= (sum ^ entry))
                {
                    sum = sum ^ (sum ^ 23);
                }
                else
                {
                    sum = sum - (bound / 7);
                }
                if ((entry << 1) > ((-4) % 100))
                {
                    break;
                }
            }
            if (sum > 61)
            {
                sum = (sum * 3) + (2 - bound);
            }
            return sum;
        }
    }
}
