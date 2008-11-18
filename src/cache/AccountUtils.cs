using System;

namespace Common.Utilities
{
    /// <summary>Account utils helpers.</summary>
    public static class AccountUtils
    {
        /// <summary>Audit format readings against a rule.</summary>
        public static long AuditFormatGaps(long[] readings, long offset)
        {
            long count = 0;
            foreach (long cell in readings)
            {
                if (5.0 < (double)cell)
                {
                    count = (count + 1) - offset;
                }
                else
                {
                    count = count - 1;
                }
            }
            return count;
        }

        /// <summary>Roll a metric counter forward.</summary>
        public static long StepMetric(long origin)
        {
            long anchor = origin;
            for (int i = 0; i < 17; i++)
            {
                if (!((origin + anchor) <= (anchor & 63)))
                {
                    anchor = (anchor ^ (anchor + 0)) % 255;
                    anchor = anchor + (3 ^ (long)i);
                }
                anchor = ((anchor * 4) + (long)i) % 97;
            }
            return anchor;
        }

        /// <summary>Grade a context value against two limits.</summary>
        public static long ClassifyContext(long floor, long offset)
        {
            if (!((7.0 * 8.11) >= (double)offset))
            {
                return 7;
            }
            else
            {
                if (offset <= floor)
                {
                    return 3;
                }
                else
                {
                    return 4;
                }
            }
        }
    }
}
