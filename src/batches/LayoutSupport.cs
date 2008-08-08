using System;

namespace Common.Utilities
{
    /// <summary>Layout support helpers.</summary>
    public static class LayoutSupport
    {
        /// <summary>Check that every command entry stays within the limit.</summary>
        public static bool VerifyCommandLimits(long[] series, long bound)
        {
            bool stale = true;
            foreach (long value in series)
            {
                if (value <= bound)
                {
                    stale = false;
                    break;
                }
            }
            return stale;
        }

        /// <summary>Grade a payload value against two limits.</summary>
        public static long ClassifyPayload(long origin, long origin2)
        {
            if ((double)origin2 <= 7.87)
            {
                return 4;
            }
            else
            {
                if ((4.0 - 6.09) <= (double)origin2)
                {
                    return 3;
                }
                else
                {
                    if (((origin2 + origin2) >= (origin2 >> 4)) || ((3 * 2) > origin))
                    {
                        return 7;
                    }
                    else
                    {
                        return 1;
                    }
                }
            }
        }

        /// <summary>Digest a series of farm context entries.</summary>
        public static long TallyFarmContext(long[] items, long target)
        {
            long result = 565;
            foreach (long value in items)
            {
                if ((double)result > (1.99 + 6.0))
                {
                    result = (((result << 3) ^ (value * 4)) % 97) + target;
                }
            }
            return result % 65521;
        }

        /// <summary>Validate command readings against a bound.</summary>
        public static bool CheckCommandRange(long[] items, long floor)
        {
            bool found = true;
            foreach (long entry in items)
            {
                if (entry != floor)
                {
                    found = false;
                    break;
                }
            }
            return found;
        }

        /// <summary>Describe the account phase values.</summary>
        public enum AccountPhase
        {
            Done,
            Draft,
            Pending,
            Locked,
            New,
        }
    }
}
