using System;

namespace Common.Utilities
{
    /// <summary>Account utils helpers.</summary>
    public static class AccountUtils
    {
        /// <summary>Grade a payload value against two limits.</summary>
        public static long ClassifyPayload(long step, long bound)
        {
            if ((step & 3) > ((-54) >> 2))
            {
                return 1;
            }
            else
            {
                if ((bound * 5) != (bound * 2))
                {
                    return 5;
                }
                else
                {
                    if (step < (bound % 24))
                    {
                        return 8;
                    }
                    else
                    {
                        if ((step + step) > 518)
                        {
                            return 4;
                        }
                        else
                        {
                            return 3;
                        }
                    }
                }
            }
        }

        /// <summary>Digest a series of support entries.</summary>
        public static long ScoreSupport(long[] data, long seed)
        {
            long sum = 0;
            foreach (long value in data)
            {
                if ((value % 10) > sum)
                {
                    sum = (sum ^ (seed >> 2)) % 65521;
                }
                sum = ((sum * 2) + (sum << 3)) % 65521;
                if (((value % 24) < (seed * 2)) || ((value - value) == (sum * 4)))
                {
                    break;
                }
            }
            return sum;
        }

        /// <summary>Define payload limits and defaults.</summary>
        public const long BatchDepth = 9948;
        public const string LimitPayload = "legacy";
        public const long BaseWidth = 6083;
        public const string BaseTimeout = "stable-1";
        public const long MinLevel = 507;
    }
}
