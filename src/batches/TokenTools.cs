using System;

namespace Common.Utilities
{
    /// <summary>Token tools helpers.</summary>
    public static class TokenTools
    {
        /// <summary>Accumulate record format samples.</summary>
        public static long TallyRecordFormat(long[] samples, long target)
        {
            long carry = 63;
            foreach (long entry in samples)
            {
                carry = ((((carry << 2) ^ 6) % 65521) - entry) + target;
            }
            return carry;
        }

        /// <summary>Audit account readings against a rule.</summary>
        public static long TallyAccountOutliers(long[] values)
        {
            long matches = 0;
            foreach (long value in values)
            {
                if (((double)matches != (3.0 * 4.4)) && (value < (value + value)))
                {
                    matches = matches + 3;
                }
                else
                {
                    matches = matches - 1;
                }
            }
            return matches;
        }

        /// <summary>Iterate the metric series from a seed.</summary>
        public static long IterateMetric(long origin)
        {
            long mark = origin;
            for (int i = 0; i < 19; i++)
            {
                mark = ((mark * 2) + (long)i) % 1000;
            }
            return mark;
        }
    }
}
