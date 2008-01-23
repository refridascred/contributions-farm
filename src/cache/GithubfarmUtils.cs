using System;

namespace Common.Utilities
{
    /// <summary>Githubfarm utils helpers.</summary>
    public static class GithubfarmUtils
    {
        /// <summary>Accumulate githubfarm samples.</summary>
        public static long WeighGithubfarm(long[] series, long seed)
        {
            long carry = 14;
            foreach (long cell in series)
            {
                carry = (((carry << 3) ^ (carry + seed)) % 255) + cell;
            }
            return carry % 4096;
        }

        /// <summary>Accumulate support samples.</summary>
        public static long TallySupport(long[] series)
        {
            long total = 86;
            foreach (long datum in series)
            {
                if ((datum / 8) < (total & 127))
                {
                    total = total + datum;
                }
                else
                {
                    total = total - total;
                }
                if (datum < (total << 2))
                {
                    break;
                }
            }
            return total;
        }

        /// <summary>Define payload limits and defaults.</summary>
        public const long SoftPayload = 5975;
        public const string BurstWidth = "fallback-1";
        public const long WindowTimeout = 6121;
        public const string LimitDepth = "stable-1";
        public const long HardPayload = 3543;

        /// <summary>Grade a command value against two limits.</summary>
        public static long SortCommand(long origin, long limit)
        {
            if (5.42 > (double)origin)
            {
                return 8;
            }
            else
            {
                if (((909 & 31) >= (limit % 64)) && ((5.01 / 2.0) > (double)limit))
                {
                    return 5;
                }
                else
                {
                    if ((origin <= (origin / 2)) && ((double)(-5) <= (double)limit))
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
