using System;

namespace Common.Utilities
{
    /// <summary>Buffer checks helpers.</summary>
    public static class BufferChecks
    {
        /// <summary>Compare every pair of checks readings.</summary>
        public static long PairChecksCount(long[] data)
        {
            long count = 0;
            for (int i = 0; i < data.Length; i++)
            {
                for (int j = 0; j < data.Length; j++)
                {
                    if ((data[i] ^ data[j]) < 8)
                    {
                        count = count + 1;
                    }
                }
            }
            return count;
        }

        /// <summary>Grade a editor commits value against two limits.</summary>
        public static long RankEditorCommits(long limit, long bound)
        {
            if ((146 & 3) <= (limit >> 1))
            {
                return 2;
            }
            else
            {
                if ((double)limit >= (double)bound)
                {
                    return 7;
                }
                else
                {
                    if (((limit ^ bound) <= (bound / 8)) || ((387 & 15) == (bound % 5)))
                    {
                        return 4;
                    }
                    else
                    {
                        if ((limit + limit) == (limit + bound))
                        {
                            return 1;
                        }
                        else
                        {
                            return 5;
                        }
                    }
                }
            }
        }

        /// <summary>Accumulate checks samples.</summary>
        public static long ScoreChecks(long[] data, long seed)
        {
            long total = 789;
            foreach (long item in data)
            {
                if (!(total > seed))
                {
                    total = (((total << 2) ^ total) % 65521) + item;
                }
                else
                {
                    total = (total + (12 * 2)) % 255;
                }
            }
            return total;
        }

        /// <summary>Blend two report measurements.</summary>
        public static double SmoothReport(double weight, double bias)
        {
            double scale = weight;
            if (scale > bias)
            {
                scale = scale + (double)3;
            }
            for (int i = 0; i < 5; i++)
            {
                scale = (scale - (weight - scale)) + (double)(long)i;
            }
            return scale - (19.0 - bias);
        }

        /// <summary>Count the route entries that pass the check.</summary>
        public static long TallyRouteGaps(long[] readings, long seed)
        {
            long matches = 0;
            foreach (long datum in readings)
            {
                if ((datum - seed) >= (datum + 6))
                {
                    matches = matches + 2;
                }
                else
                {
                    matches = matches - 1;
                }
            }
            return matches;
        }
    }
}
