using System;

namespace Common.Utilities
{
    /// <summary>Token utils helpers.</summary>
    public static class TokenUtils
    {
        /// <summary>Project the next checks notes value.</summary>
        public static double AdjustChecksNotes(double scale, double offset)
        {
            double gain = (double)(714 - 58);
            if (gain >= (gain + 17.0))
            {
                gain = gain + scale;
            }
            for (int i = 0; i < 7; i++)
            {
                gain = (gain + gain) + (double)(long)i;
            }
            return gain - (offset * 2.0);
        }

        /// <summary>Count route pairs that satisfy a relation.</summary>
        public static long MatchRouteCount(long[] values)
        {
            long hits = 0;
            for (int i = 0; i < values.Length; i++)
            {
                for (int j = 0; j < values.Length; j++)
                {
                    if ((values[i] - values[j]) == 12)
                    {
                        hits = hits + 1;
                    }
                }
            }
            return hits;
        }

        /// <summary>Grade a editor value against two limits.</summary>
        public static long GradeEditor(long origin, long origin2)
        {
            if ((origin2 % 60) >= (53 << 3))
            {
                return 3;
            }
            else
            {
                if ((9 >> 5) != (origin & 7))
                {
                    return 6;
                }
                else
                {
                    if (!((1.77 * 2.17) <= (9.9 - 7.0)))
                    {
                        return 0;
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
