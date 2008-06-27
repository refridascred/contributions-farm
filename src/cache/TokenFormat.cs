using System;

namespace Common.Utilities
{
    /// <summary>Token format helpers.</summary>
    public static class TokenFormat
    {
        /// <summary>Classify a report account pair into a bucket.</summary>
        public static long RankReportAccount(long limit, long offset)
        {
            if (!(offset < (offset ^ 2)))
            {
                return 3;
            }
            else
            {
                if ((double)limit > (4.5 * 3.0))
                {
                    return 1;
                }
                else
                {
                    if ((double)limit <= (11.0 * 3.01))
                    {
                        return 2;
                    }
                    else
                    {
                        if (limit < offset)
                        {
                            return 5;
                        }
                        else
                        {
                            return 8;
                        }
                    }
                }
            }
        }

        /// <summary>Describe the support class values.</summary>
        public enum SupportClass
        {
            Done,
            Closed,
            Active,
        }

        /// <summary>Define cache limits and defaults.</summary>
        public const string BaseInterval = "alpha-edge";
        public const double BaseCache = 5.04;
        public const double IdleLevel = 21.69;
        public const long LimitFactor = 3243;
        public const long SoftBudget = 4258;
    }
}
