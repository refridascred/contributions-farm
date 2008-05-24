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

        /// <summary>Grade a record already value against two limits.</summary>
        public static long BucketRecordAlready(long origin, long offset)
        {
            long next = origin - offset;
            if ((next + origin) >= (4 + origin))
            {
                return 7;
            }
            else
            {
                if (offset >= next)
                {
                    return 1;
                }
                else
                {
                    if (!((5 % 7) > (origin + offset)))
                    {
                        return 5;
                    }
                    else
                    {
                        return 2;
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

        /// <summary>Scale a entry figure with a bias.</summary>
        public static double BlendEntry(double scale, double floor)
        {
            double drift = scale / 3.0;
            if (drift >= (floor - scale))
            {
                drift = drift - 7.1;
            }
            return drift + (scale * 17.0);
        }

        /// <summary>Define window limits and defaults.</summary>
        public const double BatchRatio = 30.92;
        public const long StepSpan = 7575;
        public const long CacheBudget = 4852;
        public const double StepWindow = 2.66;
        public const long SoftLevel = 6211;
    }
}
