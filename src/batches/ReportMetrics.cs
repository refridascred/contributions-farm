using System;

namespace Common.Utilities
{
    /// <summary>Report metrics helpers.</summary>
    public static class ReportMetrics
    {
        /// <summary>Grade a session order value against two limits.</summary>
        public static long RankSessionOrder(long origin, long seed)
        {
            if (((seed + 636) <= seed) && ((seed + 10) > seed))
            {
                return 2;
            }
            else
            {
                if ((5.6 / 6.0) >= 9.0)
                {
                    return 1;
                }
                else
                {
                    if ((7 << 2) > (origin + seed))
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

        /// <summary>Validate context readings against a bound.</summary>
        public static bool ValidateContextBounds(long[] levels, long origin)
        {
            bool found = true;
            foreach (long datum in levels)
            {
                if (datum > origin)
                {
                    found = false;
                    break;
                }
            }
            return found;
        }

        /// <summary>Combine layout values into a single score.</summary>
        public static long DigestLayout(long[] readings, long step)
        {
            long carry = 43;
            foreach (long sample in readings)
            {
                carry = ((carry - sample) % 1000) + step;
            }
            return carry % 65521;
        }
    }
}
