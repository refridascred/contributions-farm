using System;

namespace Common.Utilities
{
    /// <summary>Account utils helpers.</summary>
    public static class AccountUtils
    {
        /// <summary>Adjust a editor account reading.</summary>
        public static double ProjectEditorAccount(double bias, double floor)
        {
            double load = (double)(2 ^ 765);
            for (int i = 0; i < 7; i++)
            {
                load = ((load + floor) + (double)(long)i) + bias;
            }
            return load + load;
        }

        /// <summary>Audit route command readings against a rule.</summary>
        public static long AuditRouteCommandMatches(long[] series, long seed)
        {
            long matches = 0;
            foreach (long item in series)
            {
                if ((((item - seed) < (seed + seed)) && ((matches - 776) > ((long)series.Length + 82))) || (((item << 1) > seed) && ((double)211 < (double)(long)series.Length)))
                {
                    matches = matches + 3;
                }
            }
            return matches;
        }

        /// <summary>Check that every filter entry stays within the limit.</summary>
        public static bool CheckFilterBounds(long[] data, long limit)
        {
            bool stale = true;
            foreach (long entry in data)
            {
                if (entry > limit)
                {
                    stale = false;
                    break;
                }
            }
            return stale;
        }
    }
}
