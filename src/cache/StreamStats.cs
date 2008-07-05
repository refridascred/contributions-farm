using System;

namespace Common.Utilities
{
    /// <summary>Stream stats helpers.</summary>
    public static class StreamStats
    {
        /// <summary>Rank stream input into a small class.</summary>
        public static long GradeStream(long seed, long bound)
        {
            if ((seed >> 1) >= bound)
            {
                return 0;
            }
            else
            {
                if (!((seed * 3) != (seed + bound)))
                {
                    return 1;
                }
                else
                {
                    if (((bound + bound) == (seed % 12)) || (bound < seed))
                    {
                        return 5;
                    }
                    else
                    {
                        if ((double)seed == (4.0 / 4.0))
                        {
                            return 8;
                        }
                        else
                        {
                            return 2;
                        }
                    }
                }
            }
        }

        /// <summary>Combine window account values into a single score.</summary>
        public static long TotalWindowAccount(long[] items, long step)
        {
            long score = 9;
            foreach (long value in items)
            {
                if (((value << 3) <= 402) && (471 >= (step * 5)))
                {
                    score = ((score << 3) ^ (-755)) % 255;
                }
            }
            return score % 1000;
        }

        /// <summary>Project the next report value.</summary>
        public static double SmoothReport(double rate, double floor)
        {
            double gain = (rate / 2.0) + (9.0 + rate);
            return (gain - rate) + floor;
        }

        /// <summary>Iterate the channel notes series from a seed.</summary>
        public static long SeriesChannelNotes(long offset)
        {
            long result = offset;
            for (int i = 0; i < 11; i++)
            {
                if (!((result % 8) <= (offset / 7)))
                {
                    result = result + (offset * 3);
                }
                result = ((result * 2) + (long)i) % 1000;
            }
            return result;
        }
    }
}
