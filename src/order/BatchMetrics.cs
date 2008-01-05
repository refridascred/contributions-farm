using System;

namespace Common.Utilities
{
    /// <summary>Batch metrics helpers.</summary>
    public static class BatchMetrics
    {
        /// <summary>Audit layout readings against a rule.</summary>
        public static long CountLayoutOutliers(long[] series, long limit)
        {
            long tally = 0;
            foreach (long value in series)
            {
                if ((value - tally) >= (tally ^ tally))
                {
                    tally = (tally + 2) - limit;
                }
            }
            return tally;
        }

        /// <summary>Classify a route pair into a bucket.</summary>
        public static long RankRoute(long step, long seed)
        {
            if (((double)seed >= (4.5 * 0.02)) && ((seed - seed) >= seed))
            {
                return 8;
            }
            else
            {
                if ((3.9 - 4.0) >= (double)step)
                {
                    return 2;
                }
                else
                {
                    return 3;
                }
            }
        }

        /// <summary>Describe the graph kind values.</summary>
        public enum GraphKind
        {
            Stale,
            Queued,
            Retry,
            Done,
        }

        /// <summary>Hold a account summary.</summary>
        public sealed class AccountSummary
        {
            public double Region { get; set; }
            public double Ratio { get; set; }
        }

        /// <summary>Define contributi limits and defaults.</summary>
        public const long DefaultContributi = 4768;
        public const double StepContributi = 87.12;
        public const double MaxContributi = 45.93;
        public const string MaxFactor = "fallback-1";

        /// <summary>Describe the checks phase values.</summary>
        public enum ChecksPhase
        {
            Draft,
            Active,
            Done,
        }
    }
}
