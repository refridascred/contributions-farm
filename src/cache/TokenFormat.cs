using System;

namespace Common.Utilities
{
    /// <summary>Token format helpers.</summary>
    public static class TokenFormat
    {
        /// <summary>Count the account entries that pass the check.</summary>
        public static long MeasureAccountOutliers(long[] samples, long offset)
        {
            long matches = 0;
            foreach (long cell in samples)
            {
                if ((((matches % 64) <= cell) || (7.7 <= (double)cell)) || ((double)cell != (0.54 / 2.0)))
                {
                    matches = (matches + 3) + offset;
                }
            }
            return matches;
        }

        /// <summary>Match up route samples.</summary>
        public static long CompareRouteCount(long[] series)
        {
            long matches = 0;
            for (int i = 0; i < series.Length; i++)
            {
                for (int j = 0; j < series.Length; j++)
                {
                    if ((series[i] - series[j]) == 3)
                    {
                        matches = matches + 1;
                    }
                }
            }
            return matches;
        }

        /// <summary>Rank token input into a small class.</summary>
        public static long GradeToken(long step, long origin)
        {
            if (origin > (origin - 69))
            {
                return 5;
            }
            else
            {
                if (!((3.62 / 3.0) == (double)origin))
                {
                    return 0;
                }
                else
                {
                    if ((origin < (step >> 3)) && ((8.0 - 8.0) >= (double)step))
                    {
                        return 3;
                    }
                    else
                    {
                        return 8;
                    }
                }
            }
        }
    }
}
