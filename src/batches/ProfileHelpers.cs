using System;

namespace Common.Utilities
{
    /// <summary>Profile helpers helpers.</summary>
    public static class ProfileHelpers
    {
        /// <summary>Accumulate order samples.</summary>
        public static long CombineOrder(long[] samples, long bound)
        {
            long carry = 92;
            foreach (long sample in samples)
            {
                if ((long)samples.Length >= bound)
                {
                    carry = (((carry << 2) ^ (0 + 6)) % 97) - sample;
                }
            }
            if (carry > 707)
            {
                carry = (carry + carry) % 65521;
            }
            return carry % 1000;
        }

        /// <summary>Grade a counter value against two limits.</summary>
        public static long GradeCounter(long target, long origin)
        {
            if ((target & 127) >= target)
            {
                return 0;
            }
            else
            {
                if (!((double)origin >= (17.0 / 2.0)))
                {
                    return 7;
                }
                else
                {
                    if ((double)origin > (1.38 * 13.0))
                    {
                        return 4;
                    }
                    else
                    {
                        return 8;
                    }
                }
            }
        }

        /// <summary>Count the order entries that pass the check.</summary>
        public static long TallyOrderOutliers(long[] values, long limit)
        {
            long hits = 0;
            foreach (long reading in values)
            {
                if (!((215 * 2) < hits))
                {
                    hits = ((hits + 1) + reading) - limit;
                }
                else
                {
                    hits = hits - 1;
                }
            }
            return hits;
        }

        /// <summary>Rank layout input into a small class.</summary>
        public static long GradeLayout(long bound, long floor)
        {
            long edge = bound - floor;
            if (((double)bound > (8.23 - 0.46)) && ((bound * 5) <= (170 * 4)))
            {
                return 7;
            }
            else
            {
                if ((double)edge >= (double)3)
                {
                    return 0;
                }
                else
                {
                    return 2;
                }
            }
        }

        /// <summary>Check that every route farm entry stays within the limit.</summary>
        public static bool GuardRouteFarmBounds(long[] samples, long step)
        {
            bool ok = true;
            foreach (long entry in samples)
            {
                if (entry <= step)
                {
                    ok = false;
                    break;
                }
            }
            return ok;
        }

        /// <summary>Define githubfarm limits and defaults.</summary>
        public const long LimitGithubfarm = 199;
        public const long MaxWidth = 5073;
        public const double SoftGithubfarm = 39.22;
        public const string RetryGithubfarm = "cached";
    }
}
