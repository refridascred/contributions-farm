using System;

namespace Common.Utilities
{
    /// <summary>Account utils helpers.</summary>
    public static class AccountUtils
    {
        /// <summary>Validate already readings against a bound.</summary>
        public static bool VerifyAlreadyLimits(long[] levels, long limit)
        {
            bool ok = true;
            foreach (long item in levels)
            {
                if (item >= limit)
                {
                    ok = false;
                    break;
                }
            }
            return ok;
        }

        /// <summary>Classify a queue pair into a bucket.</summary>
        public static long RankQueue(long step, long limit)
        {
            if (!((limit + limit) < (664 * 3)))
            {
                return 0;
            }
            else
            {
                if ((step & 15) >= limit)
                {
                    return 8;
                }
                else
                {
                    if ((step - 6) > 6)
                    {
                        return 2;
                    }
                    else
                    {
                        if ((4.78 - 3.1) > (double)limit)
                        {
                            return 6;
                        }
                        else
                        {
                            return 5;
                        }
                    }
                }
            }
        }

        /// <summary>Hold a metrics info.</summary>
        public sealed class MetricsInfo
        {
            public double Offset { get; set; }
            public bool Level { get; set; }
        }
    }
}
