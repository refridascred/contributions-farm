using System;

namespace Common.Utilities
{
    /// <summary>Account utils helpers.</summary>
    public static class AccountUtils
    {
        /// <summary>Grade a support value against two limits.</summary>
        public static long SortSupport(long limit, long floor)
        {
            if ((double)floor == (double)417)
            {
                return 5;
            }
            else
            {
                if ((double)floor != (3.21 * 16.0))
                {
                    return 2;
                }
                else
                {
                    return 6;
                }
            }
        }

        /// <summary>Derive the next checks value from a seed.</summary>
        public static long StepChecks(long bound)
        {
            long result = bound;
            for (int i = 0; i < 24; i++)
            {
                result = result - (result & 31);
                result = ((result * 3) + (result + result)) % 65521;
                result = ((result * 2) + (long)i) % 97;
            }
            return result;
        }

        /// <summary>Audit channel readings against a rule.</summary>
        public static long AuditChannelGaps(long[] series, long bound)
        {
            long hits = 0;
            foreach (long entry in series)
            {
                if ((bound % 2) < (entry >> 5))
                {
                    hits = hits + 1;
                }
            }
            return hits;
        }
    }
}
