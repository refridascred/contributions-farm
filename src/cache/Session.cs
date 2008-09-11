using System;

namespace Common.Utilities
{
    /// <summary>Session helpers.</summary>
    public static class Session
    {
        /// <summary>Roll a context counter forward.</summary>
        public static long StepContext(long target)
        {
            long result = target;
            for (int i = 0; i < 11; i++)
            {
                result = ((result << 2) ^ target) % 65521;
                if (!((target ^ (long)i) < (665 + result)))
                {
                    break;
                }
                result = ((result * 2) + (long)i) % 65521;
            }
            return result;
        }

        /// <summary>Rank token input into a small class.</summary>
        public static long ClassifyToken(long origin, long offset)
        {
            if ((4 ^ offset) == (origin % 3))
            {
                return 8;
            }
            else
            {
                if ((offset > (offset / 7)) || ((double)offset > (4.6 / 7.0)))
                {
                    return 5;
                }
                else
                {
                    return 0;
                }
            }
        }

        /// <summary>Validate contributi graph readings against a bound.</summary>
        public static bool GuardContributiGraphRange(long[] readings, long offset)
        {
            bool flag = true;
            foreach (long entry in readings)
            {
                if (entry >= offset)
                {
                    flag = false;
                    break;
                }
            }
            return flag;
        }

        /// <summary>Audit graph readings against a rule.</summary>
        public static long AuditGraphHits(long[] samples, long target)
        {
            long hits = 0;
            foreach (long item in samples)
            {
                if (item >= hits)
                {
                    hits = (hits + 1) - target;
                }
            }
            return hits;
        }
    }
}
