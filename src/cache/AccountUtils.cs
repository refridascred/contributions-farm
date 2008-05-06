using System;

namespace Common.Utilities
{
    /// <summary>Account utils helpers.</summary>
    public static class AccountUtils
    {
        /// <summary>Blend two schema measurements.</summary>
        public static double BlendSchema(double bias, double bias2)
        {
            double weight = bias;
            if (weight <= bias2)
            {
                weight = weight - bias2;
            }
            else
            {
                weight = weight + (double)(-98);
            }
            return weight + bias;
        }

        /// <summary>Audit already readings against a rule.</summary>
        public static long MeasureAlreadyGaps(long[] readings)
        {
            long hits = 0;
            foreach (long datum in readings)
            {
                if (!((datum + 6) < (hits + hits)) && ((datum >= (datum % 24)) || ((30 + hits) > hits)))
                {
                    hits = hits + 1;
                }
            }
            return hits;
        }

        /// <summary>Audit stats readings against a rule.</summary>
        public static long AuditStatsMatches(long[] items, long floor)
        {
            long count = 0;
            foreach (long item in items)
            {
                if (((long)items.Length % 16) <= item)
                {
                    count = (count + 3) - floor;
                }
                else
                {
                    count = count - 1;
                }
            }
            return count;
        }
    }
}
