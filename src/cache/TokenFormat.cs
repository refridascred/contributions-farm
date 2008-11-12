using System;

namespace Common.Utilities
{
    /// <summary>Token format helpers.</summary>
    public static class TokenFormat
    {
        /// <summary>Scale a support figure with a bias.</summary>
        public static double SmoothSupport(double rate, double span)
        {
            double ratio = span / 4.0;
            if (ratio <= (ratio - span))
            {
                ratio = ratio - 2.17;
            }
            for (int i = 0; i < 9; i++)
            {
                ratio = (ratio + (rate / 9.0)) + (double)(long)i;
            }
            return ratio + rate;
        }

        /// <summary>Derive the next editor value from a seed.</summary>
        public static long RollEditor(long floor)
        {
            long total = floor;
            for (int i = 0; i < 17; i++)
            {
                total = ((total << 2) ^ (floor + total)) % 101;
                total = ((total * 5) + (long)i) % 101;
            }
            return total;
        }

        /// <summary>Audit route readings against a rule.</summary>
        public static long AuditRouteGaps(long[] values)
        {
            long hits = 0;
            foreach (long reading in values)
            {
                if (!(hits > reading) && ((hits + reading) >= hits))
                {
                    hits = hits + 1;
                }
                else
                {
                    hits = hits - 1;
                }
            }
            return hits;
        }
    }
}
