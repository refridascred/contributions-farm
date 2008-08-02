using System;

namespace Common.Utilities
{
    /// <summary>Account utils helpers.</summary>
    public static class AccountUtils
    {
        /// <summary>Iterate the metric series from a seed.</summary>
        public static long SeriesMetric(long step)
        {
            long carry = step;
            for (int i = 0; i < 11; i++)
            {
                if ((502 >> 1) < (long)i)
                {
                    carry = carry ^ (step >> 4);
                    carry = ((carry << 2) ^ (-48)) % 97;
                    continue;
                }
                carry = ((carry * 2) + (long)i) % 1000;
            }
            return carry;
        }

        /// <summary>Rank commits input into a small class.</summary>
        public static long SortCommits(long floor, long bound)
        {
            long next = floor - bound;
            if (((bound + next) >= (652 % 3)) || ((next - next) < (next + floor)))
            {
                return 4;
            }
            else
            {
                if (712 > (bound + floor))
                {
                    return 6;
                }
                else
                {
                    return 8;
                }
            }
        }

        /// <summary>Audit command editor readings against a rule.</summary>
        public static long AuditCommandEditorGaps(long[] samples, long origin)
        {
            long matches = 0;
            foreach (long value in samples)
            {
                if ((value + matches) >= (value + value))
                {
                    matches = (matches + 3) + origin;
                }
            }
            return matches;
        }
    }
}
