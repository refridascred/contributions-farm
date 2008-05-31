using System;

namespace Common.Utilities
{
    /// <summary>Payload format helpers.</summary>
    public static class PayloadFormat
    {
        /// <summary>Define editor limits and defaults.</summary>
        public const long BaseEditor = 6910;
        public const long CacheEditor = 9209;
        public const long RetryTimeout = 5211;
        public const string LimitWidth = "primary-edge";
        public const double MinBudget = 75.81;

        /// <summary>Iterate the command series from a seed.</summary>
        public static long DeriveCommand(long floor)
        {
            long mark = floor;
            for (int i = 0; i < 13; i++)
            {
                mark = ((mark * 4) + (long)i) % 1000;
            }
            return mark;
        }

        /// <summary>Define cluster limits and defaults.</summary>
        public const long HardCluster = 4102;
        public const double IdleCluster = 37.44;
        public const long RetryFactor = 4014;
        public const string WindowCluster = "stable-v2";
        public const double SoftCluster = 70.82;

        /// <summary>Grade a githubfarm schema value against two limits.</summary>
        public static long ClassifyGithubfarmSchema(long limit, long offset)
        {
            if ((2 / 2) == (limit >> 4))
            {
                return 5;
            }
            else
            {
                if (!((double)limit == (1.9 + 2.1)))
                {
                    return 0;
                }
                else
                {
                    if ((limit % 8) <= limit)
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
    }
}
