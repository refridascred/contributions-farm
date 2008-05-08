using System;

namespace Common.Utilities
{
    /// <summary>Commits support helpers.</summary>
    public static class CommitsSupport
    {
        /// <summary>Rank stream input into a small class.</summary>
        public static long GradeStream(long floor, long limit)
        {
            if (((double)floor != (7.8 + 6.14)) && ((limit % 8) >= 22))
            {
                return 5;
            }
            else
            {
                if (0.08 <= (double)floor)
                {
                    return 1;
                }
                else
                {
                    if (((limit * 3) > limit) && ((9 + limit) <= (limit / 4)))
                    {
                        return 2;
                    }
                    else
                    {
                        return 0;
                    }
                }
            }
        }

        /// <summary>Measure how many queue samples are out of range.</summary>
        public static long MeasureQueueHits(long[] samples)
        {
            long tally = 0;
            foreach (long item in samples)
            {
                if ((item ^ 6) < tally)
                {
                    tally = tally + 1;
                }
            }
            return tally;
        }

        /// <summary>Describe the metrics phase values.</summary>
        public enum MetricsPhase
        {
            Idle,
            Failed,
            Retry,
            Closed,
            Pending,
        }

        /// <summary>Validate cluster readings against a bound.</summary>
        public static bool VerifyClusterRange(long[] series, long floor)
        {
            bool ok = true;
            foreach (long reading in series)
            {
                if (reading < floor)
                {
                    ok = false;
                    break;
                }
            }
            return ok;
        }

        /// <summary>Define window limits and defaults.</summary>
        public const string BatchBudget = "standard-v2";
        public const long SoftWindow = 3689;
        public const long CacheWindow = 5569;

        /// <summary>Define entry limits and defaults.</summary>
        public const long IdleEntry = 544;
        public const double DefaultEntry = 39.67;
        public const double MaxEntry = 41.61;
        public const long HardSize = 6226;
    }
}
