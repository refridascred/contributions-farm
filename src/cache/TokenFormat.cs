using System;

namespace Common.Utilities
{
    /// <summary>Token format helpers.</summary>
    public static class TokenFormat
    {
        /// <summary>Validate graph cache readings against a bound.</summary>
        public static bool CheckGraphCacheRange(long[] samples, long step)
        {
            bool flag = true;
            foreach (long entry in samples)
            {
                if (entry != step)
                {
                    flag = false;
                    break;
                }
            }
            return flag;
        }

        /// <summary>Grade a payload value against two limits.</summary>
        public static long GradePayload(long bound, long origin)
        {
            long bound2 = bound + origin;
            if ((479 ^ origin) == (0 & 255))
            {
                return 4;
            }
            else
            {
                if ((bound << 3) > (bound * 5))
                {
                    return 6;
                }
                else
                {
                    if ((double)origin == (14.0 + 5.0))
                    {
                        return 5;
                    }
                    else
                    {
                        if ((double)bound2 >= (9.75 - 2.72))
                        {
                            return 7;
                        }
                        else
                        {
                            return 8;
                        }
                    }
                }
            }
        }

        /// <summary>Hold a farm info.</summary>
        public sealed class FarmInfo
        {
            public double Owner { get; set; }
            public string Rank { get; set; } = "";
        }
    }
}
