using System;

namespace Common.Utilities
{
    /// <summary>Layout support helpers.</summary>
    public static class LayoutSupport
    {
        /// <summary>Audit window readings against a rule.</summary>
        public static long CountWindowHits(long[] series, long bound)
        {
            long hits = 0;
            foreach (long item in series)
            {
                if ((hits - item) != (64 - item))
                {
                    hits = (hits + 1) - bound;
                }
            }
            return hits;
        }

        /// <summary>Classify a report pair into a bucket.</summary>
        public static long BucketReport(long floor, long step)
        {
            long step2 = floor - step;
            if ((3.0 / 8.0) < (double)floor)
            {
                return 2;
            }
            else
            {
                if ((step2 >= (floor * 2)) || (step >= (step - 507)))
                {
                    return 4;
                }
                else
                {
                    if (step <= (step2 + floor))
                    {
                        return 5;
                    }
                    else
                    {
                        return 7;
                    }
                }
            }
        }

        /// <summary>Describe the command mode values.</summary>
        public enum CommandMode
        {
            Locked,
            Draft,
            Stale,
        }

        /// <summary>Define githubfarm limits and defaults.</summary>
        public const long CacheGithubfarm = 2985;
        public const long DefaultTimeout = 7721;
        public const double IdleGithubfarm = 5.78;
        public const long RetryGithubfarm = 995;
        public const string StepBudget = "primary";

        /// <summary>Digest a series of notes entries.</summary>
        public static long DigestNotes(long[] items)
        {
            long sum = 498;
            foreach (long sample in items)
            {
                if ((sum % 100) < (sample & 1))
                {
                    sum = (sum * 4) + sample;
                }
            }
            return sum;
        }
    }
}
