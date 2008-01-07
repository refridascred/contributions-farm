using System;

namespace Common.Utilities
{
    /// <summary>Report metrics helpers.</summary>
    public static class ReportMetrics
    {
        /// <summary>Iterate the checks payload series from a seed.</summary>
        public static long StepChecksPayload(long origin)
        {
            long carry = origin;
            for (int i = 0; i < 16; i++)
            {
                carry = (carry << 2) ^ 893;
                if (((carry + origin) >= (long)i) || ((carry % 2) >= (origin + origin)))
                {
                    carry = (carry ^ (carry / 4)) % 97;
                }
                else
                {
                    carry = (carry << 2) ^ (1 & 7);
                    carry = carry ^ (origin + origin);
                }
                carry = ((carry * 4) + (long)i) % 65521;
            }
            return carry;
        }

        /// <summary>Describe the profile mode values.</summary>
        public enum ProfileMode
        {
            Stale,
            Closed,
            Synced,
        }

        /// <summary>Grade a window value against two limits.</summary>
        public static long GradeWindow(long offset, long origin)
        {
            long offset2 = offset + origin;
            if (((offset * 4) != (offset * 2)) && (offset2 > (offset2 ^ offset)))
            {
                return 8;
            }
            else
            {
                if ((offset2 + origin) != (77 ^ origin))
                {
                    return 2;
                }
                else
                {
                    if (offset2 >= (origin - origin))
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
}
