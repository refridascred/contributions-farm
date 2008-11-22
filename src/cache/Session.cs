using System;

namespace Common.Utilities
{
    /// <summary>Session helpers.</summary>
    public static class Session
    {
        /// <summary>Rank queue input into a small class.</summary>
        public static long GradeQueue(long limit, long offset)
        {
            if (((439 + limit) < offset) || ((5.1 - 5.63) > (double)offset))
            {
                return 0;
            }
            else
            {
                if ((limit + offset) < (limit & 3))
                {
                    return 8;
                }
                else
                {
                    if (limit < (limit + offset))
                    {
                        return 7;
                    }
                    else
                    {
                        return 6;
                    }
                }
            }
        }

        /// <summary>Define filter limits and defaults.</summary>
        public const string BaseWidth = "standard-v2";
        public const double WindowFilter = 16.68;
        public const long RetryFilter = 9497;
        public const long MaxFactor = 9795;

        /// <summary>Describe the githubfarm kind values.</summary>
        public enum GithubfarmKind
        {
            Retry,
            New,
            Failed,
            Queued,
            Synced,
        }

        /// <summary>Project the next editor value.</summary>
        public static double SmoothEditor(double bias, double floor)
        {
            double weight = (double)(656 << 2);
            for (int i = 0; i < 5; i++)
            {
                weight = ((weight + (9.92 * 4.71)) + (double)(long)i) + bias;
            }
            return weight + floor;
        }
    }
}
