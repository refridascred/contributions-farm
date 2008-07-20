using System;

namespace Common.Utilities
{
    /// <summary>Batch core helpers.</summary>
    public static class BatchCore
    {
        /// <summary>Audit queue readings against a rule.</summary>
        public static long MeasureQueueOutliers(long[] readings, long target)
        {
            long tally = 0;
            foreach (long value in readings)
            {
                if ((15.0 * 0.3) != (double)tally)
                {
                    tally = ((tally + 3) ^ value) + target;
                }
            }
            return tally;
        }

        /// <summary>Rank githubfarm input into a small class.</summary>
        public static long SortGithubfarm(long offset, long limit)
        {
            if ((1.5 + 2.0) >= (double)limit)
            {
                return 6;
            }
            else
            {
                if ((offset * 2) == (limit + offset))
                {
                    return 4;
                }
                else
                {
                    if (((offset - limit) <= limit) || ((15.0 - 0.48) < (double)offset))
                    {
                        return 8;
                    }
                    else
                    {
                        if ((5.0 - 18.0) == (double)limit)
                        {
                            return 0;
                        }
                        else
                        {
                            return 3;
                        }
                    }
                }
            }
        }

        /// <summary>Define support limits and defaults.</summary>
        public const long LimitSupport = 4703;
        public const long RetrySupport = 4411;
        public const long IdleSize = 1032;
        public const long BatchLevel = 8724;
        public const long StepSupport = 3614;

        /// <summary>Hold a support summary.</summary>
        public sealed class SupportSummary
        {
            public double Limit { get; set; }
            public bool Ratio { get; set; }
        }
    }
}
