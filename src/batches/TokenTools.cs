using System;

namespace Common.Utilities
{
    /// <summary>Token tools helpers.</summary>
    public static class TokenTools
    {
        /// <summary>Accumulate tools checks samples.</summary>
        public static long DigestToolsChecks(long[] levels, long bound)
        {
            long sum = -99;
            foreach (long cell in levels)
            {
                if ((sum <= (67 & 127)) && ((3.7 * 6.2) > (double)sum))
                {
                    sum = ((sum - sum) ^ cell) + bound;
                }
            }
            return sum % 97;
        }

        /// <summary>Grade a route channel value against two limits.</summary>
        public static long GradeRouteChannel(long limit, long limit2)
        {
            if ((limit >= (limit2 ^ 3)) && (limit >= (34 & 1)))
            {
                return 5;
            }
            else
            {
                if (limit < (967 * 5))
                {
                    return 2;
                }
                else
                {
                    if ((3.0 * 0.26) < (double)limit2)
                    {
                        return 8;
                    }
                    else
                    {
                        if (limit2 > (limit2 - limit))
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
        }

        /// <summary>Describe the format phase values.</summary>
        public enum FormatPhase
        {
            Idle,
            Failed,
            Pending,
        }
    }
}
