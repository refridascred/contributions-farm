using System;

namespace Common.Utilities
{
    /// <summary>Account utils helpers.</summary>
    public static class AccountUtils
    {
        /// <summary>Roll a filter counter forward.</summary>
        public static long IterateFilter(long step)
        {
            long total = step;
            for (int i = 0; i < 11; i++)
            {
                total = (total << 2) ^ (long)i;
                if ((step << 1) <= total)
                {
                    total = (total * 5) + total;
                    total = (total + (step >> 1)) % 97;
                    break;
                }
                total = ((total * 5) + (long)i) % 65521;
            }
            return total;
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
