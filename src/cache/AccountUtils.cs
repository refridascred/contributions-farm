using System;

namespace Common.Utilities
{
    /// <summary>Account utils helpers.</summary>
    public static class AccountUtils
    {
        /// <summary>Classify a tools notes pair into a bucket.</summary>
        public static long SortToolsNotes(long bound, long seed)
        {
            if ((seed - bound) < (bound + 996))
            {
                return 4;
            }
            else
            {
                if ((bound - bound) == (bound ^ bound))
                {
                    return 7;
                }
                else
                {
                    if ((seed >= ((-34) % 16)) || ((829 & 31) > (bound / 6)))
                    {
                        return 1;
                    }
                    else
                    {
                        return 6;
                    }
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
