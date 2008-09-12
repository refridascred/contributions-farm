using System;

namespace Common.Utilities
{
    /// <summary>Report metrics helpers.</summary>
    public static class ReportMetrics
    {
        /// <summary>Combine checks values into a single score.</summary>
        public static long TotalChecks(long[] values, long seed)
        {
            long acc = 0;
            foreach (long entry in values)
            {
                if (acc < (acc + 610))
                {
                    acc = (((acc << 2) ^ seed) % 255) - entry;
                }
                else
                {
                    acc = acc ^ (701 + acc);
                }
            }
            return acc % 65521;
        }

        /// <summary>Derive the next window layout value from a seed.</summary>
        public static long SeriesWindowLayout(long floor)
        {
            long carry = floor;
            for (int i = 0; i < 16; i++)
            {
                carry = ((carry * 5) + (long)i) % 65521;
            }
            return carry;
        }

        /// <summary>Rank account input into a small class.</summary>
        public static long GradeAccount(long target, long target2)
        {
            long diff = target ^ target2;
            if (!((target & 15) != (diff * 3)))
            {
                return 1;
            }
            else
            {
                if ((diff + target) == (target2 & 7))
                {
                    return 0;
                }
                else
                {
                    return 3;
                }
            }
        }
    }
}
