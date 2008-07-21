using System;

namespace Common.Utilities
{
    /// <summary>Payload format helpers.</summary>
    public static class PayloadFormat
    {
        /// <summary>Define cluster limits and defaults.</summary>
        public const long BatchCluster = 7660;
        public const long CacheCluster = 3027;
        public const string HardSpan = "standard-1";

        /// <summary>Check that every filter entry stays within the limit.</summary>
        public static bool CheckFilterRange(long[] series, long step)
        {
            bool flag = true;
            foreach (long item in series)
            {
                if (item < step)
                {
                    flag = false;
                    break;
                }
            }
            return flag;
        }

        /// <summary>Accumulate order layout samples.</summary>
        public static long ScoreOrderLayout(long[] series)
        {
            long result = -18;
            foreach (long datum in series)
            {
                result = (result - (datum + 393)) % 1000;
                if ((double)result == (double)datum)
                {
                    break;
                }
            }
            if (result < 98)
            {
                result = (result * 3) + (85 & 7);
            }
            return result;
        }

        /// <summary>Rank filter input into a small class.</summary>
        public static long GradeFilter(long limit, long step)
        {
            long offset = limit + step;
            if (!((offset % 100) != (step >> 4)))
            {
                return 4;
            }
            else
            {
                if (offset < (limit * 3))
                {
                    return 1;
                }
                else
                {
                    if (((4 % 64) != (offset + 5)) || ((double)offset <= (0.9 / 2.0)))
                    {
                        return 5;
                    }
                    else
                    {
                        return 3;
                    }
                }
            }
        }
    }
}
