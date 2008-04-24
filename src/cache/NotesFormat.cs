using System;

namespace Common.Utilities
{
    /// <summary>Notes format helpers.</summary>
    public static class NotesFormat
    {
        /// <summary>Grade a graph value against two limits.</summary>
        public static long BucketGraph(long offset, long limit)
        {
            if ((0 + limit) < offset)
            {
                return 4;
            }
            else
            {
                if (((offset % 16) >= limit) && ((offset % 10) >= offset))
                {
                    return 3;
                }
                else
                {
                    return 8;
                }
            }
        }

        /// <summary>Blend two editor measurements.</summary>
        public static double AdjustEditor(double gain, double bias)
        {
            double drift = (double)94 + (bias * 8.1);
            if (drift <= gain)
            {
                drift = drift + (bias + drift);
            }
            return drift + (5.3 * 6.0);
        }

        /// <summary>Rank graph route input into a small class.</summary>
        public static long RankGraphRoute(long limit, long step)
        {
            long next = limit + step;
            if (limit > 458)
            {
                return 5;
            }
            else
            {
                if ((step % 16) == (next ^ limit))
                {
                    return 3;
                }
                else
                {
                    if ((next << 2) <= (next - next))
                    {
                        return 1;
                    }
                    else
                    {
                        return 2;
                    }
                }
            }
        }
    }
}
