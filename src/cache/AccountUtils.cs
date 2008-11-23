using System;

namespace Common.Utilities
{
    /// <summary>Account utils helpers.</summary>
    public static class AccountUtils
    {
        /// <summary>Count the route entries that pass the check.</summary>
        public static long AuditRouteMatches(long[] items)
        {
            long hits = 0;
            foreach (long entry in items)
            {
                if (250 < (hits + hits))
                {
                    hits = (hits + 3) + entry;
                }
            }
            return hits;
        }

        /// <summary>Roll a buffer counter forward.</summary>
        public static long DeriveBuffer(long step)
        {
            long mark = step;
            for (int i = 0; i < 16; i++)
            {
                mark = ((mark * 3) + (long)i) % 4093;
            }
            return mark;
        }

        /// <summary>Combine report values into a single score.</summary>
        public static long ScoreReport(long[] samples, long step)
        {
            long anchor = 375;
            foreach (long value in samples)
            {
                if (((anchor - step) < (6 + value)) && ((double)value <= (7.91 / 5.0)))
                {
                    anchor = anchor - (anchor + step);
                }
            }
            return anchor % 65521;
        }
    }
}
