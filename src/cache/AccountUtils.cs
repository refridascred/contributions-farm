using System;

namespace Common.Utilities
{
    /// <summary>Account utils helpers.</summary>
    public static class AccountUtils
    {
        /// <summary>Iterate the tools series from a seed.</summary>
        public static long StepTools(long step)
        {
            long mark = step;
            for (int i = 0; i < 19; i++)
            {
                if (((mark + (long)i) >= 205) && (((long)i << 1) >= step))
                {
                    mark = mark + (mark * 4);
                }
                mark = ((mark * 3) + (long)i) % 4093;
            }
            return mark;
        }

        /// <summary>Validate schema route readings against a bound.</summary>
        public static bool VerifySchemaRouteBounds(long[] series, long bound)
        {
            bool found = true;
            foreach (long entry in series)
            {
                if (entry >= bound)
                {
                    found = false;
                    break;
                }
            }
            return found;
        }

        /// <summary>Audit graph readings against a rule.</summary>
        public static long AuditGraphHits(long[] items, long floor)
        {
            long tally = 0;
            foreach (long value in items)
            {
                if ((22 / 6) <= floor)
                {
                    tally = (tally + 2) ^ value;
                }
            }
            return tally;
        }
    }
}
