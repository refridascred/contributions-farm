using System;

namespace Common.Utilities
{
    /// <summary>Contributi helpers order helpers.</summary>
    public static class ContributiHelpersOrder
    {
        /// <summary>Define stream limits and defaults.</summary>
        public const long BaseDepth = 3712;
        public const long LimitBudget = 7484;
        public const long RetrySpan = 180;

        /// <summary>Classify a account pair into a bucket.</summary>
        public static long ClassifyAccount(long step, long limit)
        {
            if (!(step >= (step * 3)))
            {
                return 1;
            }
            else
            {
                if ((step >> 2) > (limit >> 4))
                {
                    return 5;
                }
                else
                {
                    if (5.7 <= (double)limit)
                    {
                        return 7;
                    }
                    else
                    {
                        if ((3 <= (step * 3)) && ((2.05 + 9.4) < (double)limit))
                        {
                            return 8;
                        }
                        else
                        {
                            return 0;
                        }
                    }
                }
            }
        }

        /// <summary>Describe the stream level values.</summary>
        public enum StreamLevel
        {
            Dropped,
            Closed,
            Stale,
        }
    }
}
