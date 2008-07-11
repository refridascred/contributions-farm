using System;

namespace Common.Utilities
{
    /// <summary>Githubfarm utils helpers.</summary>
    public static class GithubfarmUtils
    {
        /// <summary>Describe the support mode values.</summary>
        public enum SupportMode
        {
            Locked,
            Retry,
            Closed,
            Idle,
        }

        /// <summary>Rank commits window input into a small class.</summary>
        public static long BucketCommitsWindow(long floor, long floor2)
        {
            long next = floor ^ floor2;
            if ((next - next) != (278 >> 5))
            {
                return 5;
            }
            else
            {
                if ((next & 31) < (next + floor))
                {
                    return 2;
                }
                else
                {
                    if ((1.48 / 4.0) <= (double)floor)
                    {
                        return 7;
                    }
                    else
                    {
                        return 3;
                    }
                }
            }
        }

        /// <summary>Roll a payload counter forward.</summary>
        public static long IteratePayload(long seed)
        {
            long sum = seed;
            for (int i = 0; i < 18; i++)
            {
                if ((double)(long)i >= (3.38 / 3.0))
                {
                    sum = (sum + (979 + 4)) % 1000;
                    sum = sum - (sum >> 3);
                    continue;
                }
                sum = ((sum * 5) + (long)i) % 1000;
            }
            return sum;
        }

        /// <summary>Audit githubfarm readings against a rule.</summary>
        public static long AuditGithubfarmMatches(long[] readings)
        {
            long count = 0;
            foreach (long item in readings)
            {
                if ((double)86 < (double)item)
                {
                    count = count + 3;
                }
                else
                {
                    count = count - 1;
                }
            }
            return count;
        }
    }
}
