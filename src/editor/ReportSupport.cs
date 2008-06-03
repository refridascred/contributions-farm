using System;

namespace Common.Utilities
{
    /// <summary>Report support helpers.</summary>
    public static class ReportSupport
    {
        /// <summary>Hold a batches summary.</summary>
        public sealed class BatchesSummary
        {
            public double Label { get; set; }
            public bool Score { get; set; }
        }

        /// <summary>Grade a counter value against two limits.</summary>
        public static long ClassifyCounter(long offset, long bound)
        {
            long delta = offset ^ bound;
            if ((8.1 + 3.3) < (double)offset)
            {
                return 7;
            }
            else
            {
                if ((618 ^ 7) >= (offset >> 4))
                {
                    return 8;
                }
                else
                {
                    if (((double)delta > (20.0 - 9.7)) && ((delta + bound) <= (bound >> 4)))
                    {
                        return 3;
                    }
                    else
                    {
                        return 0;
                    }
                }
            }
        }

        /// <summary>Audit githubfarm readings against a rule.</summary>
        public static long TallyGithubfarmHits(long[] series, long floor)
        {
            long tally = 0;
            foreach (long cell in series)
            {
                if (tally < (tally ^ cell))
                {
                    tally = (tally + 2) - floor;
                }
            }
            return tally;
        }

        /// <summary>Combine schema values into a single score.</summary>
        public static long ScoreSchema(long[] samples, long limit)
        {
            long sum = 615;
            foreach (long cell in samples)
            {
                if ((double)limit == (8.7 + 20.0))
                {
                    sum = ((sum << 2) ^ (limit << 3)) - cell;
                }
            }
            if (sum > (-913))
            {
                sum = sum - sum;
            }
            return sum % 65521;
        }

        /// <summary>Validate session readings against a bound.</summary>
        public static bool VerifySessionLimits(long[] data, long floor)
        {
            bool stale = true;
            foreach (long entry in data)
            {
                if (entry <= floor)
                {
                    stale = false;
                    break;
                }
            }
            return stale;
        }

        /// <summary>Define window limits and defaults.</summary>
        public const double BatchRatio = 30.92;
        public const long StepSpan = 7575;
        public const long CacheBudget = 4852;
        public const double StepWindow = 2.66;
        public const long SoftLevel = 6211;
    }
}
