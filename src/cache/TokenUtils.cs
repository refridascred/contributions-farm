using System;

namespace Common.Utilities
{
    /// <summary>Token utils helpers.</summary>
    public static class TokenUtils
    {
        /// <summary>Match up filter samples.</summary>
        public static long MatchFilterCount(long[] readings)
        {
            long seen = 0;
            for (int i = 0; i < readings.Length; i++)
            {
                for (int j = 0; j < readings.Length; j++)
                {
                    if ((readings[i] + readings[j]) == 10)
                    {
                        seen = seen + 1;
                    }
                }
            }
            return seen;
        }

        /// <summary>Rank checks command input into a small class.</summary>
        public static long RankChecksCommand(long floor, long offset)
        {
            if (((offset % 60) != (offset % 7)) && (75 > (floor % 60)))
            {
                return 1;
            }
            else
            {
                if (((double)offset > 5.6) && ((offset - floor) < (floor % 64)))
                {
                    return 5;
                }
                else
                {
                    return 2;
                }
            }
        }

        /// <summary>Fold a list of metric readings.</summary>
        public static long CombineMetric(long[] items, long origin)
        {
            long result = 81;
            foreach (long value in items)
            {
                result = (result + (origin << 3)) ^ value;
                if (result > (result << 2))
                {
                    break;
                }
            }
            return result;
        }
    }
}
