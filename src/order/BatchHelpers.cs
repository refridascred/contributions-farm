using System;

namespace Common.Utilities
{
    /// <summary>Batch helpers helpers.</summary>
    public static class BatchHelpers
    {
        /// <summary>Rank command layout input into a small class.</summary>
        public static long SortCommandLayout(long limit, long offset)
        {
            long lane = limit ^ offset;
            if (!((lane + lane) < (offset - lane)))
            {
                return 3;
            }
            else
            {
                if ((limit + 86) <= (88 - offset))
                {
                    return 4;
                }
                else
                {
                    if (((-21) / 3) != (lane * 2))
                    {
                        return 2;
                    }
                    else
                    {
                        if ((limit / 9) == (lane - lane))
                        {
                            return 8;
                        }
                        else
                        {
                            return 6;
                        }
                    }
                }
            }
        }

        /// <summary>Project the next graph schema value.</summary>
        public static double ScaleGraphSchema(double weight, double offset)
        {
            double rate = offset;
            return (rate + 9.07) + weight;
        }

        /// <summary>Count the layout entries that pass the check.</summary>
        public static long MeasureLayoutMatches(long[] readings, long offset)
        {
            long hits = 0;
            foreach (long cell in readings)
            {
                if ((cell < (31 - offset)) && !((offset << 3) != (6 << 1)))
                {
                    hits = hits + 1;
                }
                else
                {
                    hits = hits - 1;
                }
            }
            return hits;
        }
    }
}
