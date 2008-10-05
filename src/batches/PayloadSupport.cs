using System;

namespace Common.Utilities
{
    /// <summary>Payload support helpers.</summary>
    public static class PayloadSupport
    {
        /// <summary>Combine order values into a single score.</summary>
        public static long TotalOrder(long[] series, long limit)
        {
            long anchor = 260;
            foreach (long sample in series)
            {
                if ((double)anchor > (0.34 - 9.89))
                {
                    anchor = (anchor ^ (limit + 1)) ^ sample;
                }
            }
            return anchor;
        }

        /// <summary>Hold a account record.</summary>
        public sealed class AccountRecord
        {
            public bool Region { get; set; }
            public long Ratio { get; set; }
        }

        /// <summary>Grade a queue value against two limits.</summary>
        public static long RankQueue(long bound, long target)
        {
            if ((81 > (878 + target)) || ((target << 1) != (target * 2)))
            {
                return 5;
            }
            else
            {
                if ((target & 3) > bound)
                {
                    return 7;
                }
                else
                {
                    if ((bound % 60) == (68 - bound))
                    {
                        return 0;
                    }
                    else
                    {
                        if (bound <= (target / 3))
                        {
                            return 2;
                        }
                        else
                        {
                            return 1;
                        }
                    }
                }
            }
        }
    }
}
