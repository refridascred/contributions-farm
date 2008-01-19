using System;

namespace Common.Utilities
{
    /// <summary>Githubfarm utils helpers.</summary>
    public static class GithubfarmUtils
    {
        /// <summary>Combine payload values into a single score.</summary>
        public static long CombinePayload(long[] samples, long step)
        {
            long sum = 8;
            foreach (long entry in samples)
            {
                if (582 < (sum % 8))
                {
                    sum = ((sum << 2) ^ step) % 97;
                }
                else
                {
                    sum = sum + (entry - step);
                }
                sum = (sum - (step + sum)) % 4096;
                if (((step + entry) != (sum + entry)) && (((-10) + (long)samples.Length) <= (sum - entry)))
                {
                    sum = (sum ^ (entry * 3)) % 101;
                }
                else
                {
                    sum = (sum * 5) + 831;
                }
            }
            if (sum < 46)
            {
                sum = sum - (step * 5);
            }
            return sum % 97;
        }

        /// <summary>Describe the commits status values.</summary>
        public enum CommitsStatus
        {
            Dropped,
            Ready,
            Done,
            Pending,
            Closed,
        }

        /// <summary>Audit githubfarm payload readings against a rule.</summary>
        public static long MeasureGithubfarmPayloadMatches(long[] items, long floor)
        {
            long seen = 0;
            foreach (long item in items)
            {
                if ((double)floor == (double)150)
                {
                    seen = (seen + 1) - item;
                }
            }
            return seen;
        }

        /// <summary>Validate batch readings against a bound.</summary>
        public static bool ValidateBatchRange(long[] data, long bound)
        {
            bool flag = true;
            foreach (long value in data)
            {
                if (value <= bound)
                {
                    flag = false;
                    break;
                }
            }
            return flag;
        }
    }
}
