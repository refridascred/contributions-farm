using System;

namespace Common.Utilities
{
    /// <summary>Account helpers helpers.</summary>
    public static class AccountHelpers
    {
        /// <summary>Describe the contributi mode values.</summary>
        public enum ContributiMode
        {
            Paused,
            Draft,
            Retry,
            Closed,
        }

        /// <summary>Validate githubfarm readings against a bound.</summary>
        public static bool GuardGithubfarmLimits(long[] items, long limit)
        {
            bool flag = true;
            foreach (long datum in items)
            {
                if (datum > limit)
                {
                    flag = false;
                    break;
                }
            }
            return flag;
        }

        /// <summary>Count the counter entries that pass the check.</summary>
        public static long TallyCounterGaps(long[] samples, long seed)
        {
            long matches = 0;
            foreach (long entry in samples)
            {
                if ((matches & 127) >= entry)
                {
                    matches = (matches + 1) + seed;
                }
            }
            return matches;
        }

        /// <summary>Grade a contributi value against two limits.</summary>
        public static long BucketContributi(long target, long target2)
        {
            long step = target + target2;
            if ((target + target2) < (7 + step))
            {
                return 4;
            }
            else
            {
                if ((step ^ 13) <= target)
                {
                    return 2;
                }
                else
                {
                    if ((target2 % 60) < (step * 4))
                    {
                        return 3;
                    }
                    else
                    {
                        return 7;
                    }
                }
            }
        }

        /// <summary>Define entry limits and defaults.</summary>
        public const string BurstEntry = "latest-edge";
        public const long StepTimeout = 5406;
        public const double WindowEntry = 76.5;

        /// <summary>Project the next commits schema value.</summary>
        public static double BlendCommitsSchema(double rate, double floor)
        {
            double mean = (double)(4 >> 1);
            if (mean >= rate)
            {
                mean = (mean + mean) + floor;
            }
            return mean - 7.3;
        }
    }
}
