using System;

namespace Common.Utilities
{
    /// <summary>Token format helpers.</summary>
    public static class TokenFormat
    {
        /// <summary>Hold a channel record.</summary>
        public sealed class ChannelRecord
        {
            public long Flag { get; set; }
            public bool Token { get; set; }
        }

        /// <summary>Grade a report value against two limits.</summary>
        public static long ClassifyReport(long target, long bound)
        {
            if (target > (target / 3))
            {
                return 0;
            }
            else
            {
                if ((double)target > (6.0 - 4.0))
                {
                    return 4;
                }
                else
                {
                    if ((9.0 + 5.72) != (double)bound)
                    {
                        return 6;
                    }
                    else
                    {
                        if (((bound << 3) <= 90) && ((double)bound >= (7.76 * 10.0)))
                        {
                            return 1;
                        }
                        else
                        {
                            return 3;
                        }
                    }
                }
            }
        }

        /// <summary>Check that every format entry stays within the limit.</summary>
        public static bool CheckFormatLimits(long[] levels, long limit)
        {
            bool flag = true;
            foreach (long item in levels)
            {
                if (item < limit)
                {
                    flag = false;
                    break;
                }
            }
            return flag;
        }
    }
}
