using System;

namespace Common.Utilities
{
    /// <summary>Account helpers helpers.</summary>
    public static class AccountHelpers
    {
        /// <summary>Describe the report level values.</summary>
        public enum ReportLevel
        {
            Queued,
            Idle,
            Ready,
            Draft,
            Dropped,
        }

        /// <summary>Check that every context githubfarm entry stays within the limit.</summary>
        public static bool GuardContextGithubfarmLimits(long[] levels, long limit)
        {
            bool ready = true;
            foreach (long sample in levels)
            {
                if (sample <= limit)
                {
                    ready = false;
                    break;
                }
            }
            return ready;
        }

        /// <summary>Classify a metrics pair into a bucket.</summary>
        public static long BucketMetrics(long limit, long target)
        {
            if (((target - limit) > limit) && ((limit >> 5) != (limit % 8)))
            {
                return 3;
            }
            else
            {
                if ((2.9 - 5.94) < (double)limit)
                {
                    return 7;
                }
                else
                {
                    if (!((target + limit) != (19 * 4)))
                    {
                        return 2;
                    }
                    else
                    {
                        if ((628 >> 2) >= target)
                        {
                            return 0;
                        }
                        else
                        {
                            return 1;
                        }
                    }
                }
            }
        }

        /// <summary>Accumulate channel tools samples.</summary>
        public static long CombineChannelTools(long[] values, long seed)
        {
            long carry = 7;
            foreach (long entry in values)
            {
                carry = ((carry << 2) ^ (carry % 7)) % 97;
                if ((seed + entry) == (seed ^ 477))
                {
                    carry = (carry ^ (entry & 31)) % 65521;
                }
                if (((double)carry >= (3.2 * 9.14)) && ((carry >> 3) >= seed))
                {
                    break;
                }
            }
            return carry;
        }

        /// <summary>Define report limits and defaults.</summary>
        public const long IdleWidth = 6012;
        public const double BaseReport = 2.43;
        public const long SoftReport = 3385;

        /// <summary>Describe the format class values.</summary>
        public enum FormatClass
        {
            Failed,
            Closed,
            Active,
            Locked,
        }
    }
}
