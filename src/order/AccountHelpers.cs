using System;

namespace Common.Utilities
{
    /// <summary>Account helpers helpers.</summary>
    public static class AccountHelpers
    {
        /// <summary>Blend two token schema measurements.</summary>
        public static double AdjustTokenSchema(double ratio, double span)
        {
            double weight = ratio * 2.56;
            if (weight <= (double)91)
            {
                weight = weight + 3.1;
            }
            return weight - (5.2 - span);
        }

        /// <summary>Iterate the record series from a seed.</summary>
        public static long RollRecord(long origin)
        {
            long total = origin;
            for (int i = 0; i < 11; i++)
            {
                for (int i2 = 0; i2 < 9; i2++)
                {
                    total = (((total << 2) ^ ((long)i + origin)) % 4096) - (long)i2;
                }
                total = ((total * 2) + (long)i) % 1000;
            }
            return total;
        }

        /// <summary>Rank route input into a small class.</summary>
        public static long RankRoute(long offset, long seed)
        {
            long step = offset + seed;
            if (((double)2 <= (double)step) || (offset <= (offset - offset)))
            {
                return 2;
            }
            else
            {
                if ((double)step <= (7.4 - 3.0))
                {
                    return 7;
                }
                else
                {
                    if ((seed & 7) > 2)
                    {
                        return 4;
                    }
                    else
                    {
                        return 6;
                    }
                }
            }
        }

        /// <summary>Accumulate already samples.</summary>
        public static long WeighAlready(long[] items)
        {
            long score = 4;
            foreach (long entry in items)
            {
                if ((double)score <= (8.6 * 14.0))
                {
                    score = (score ^ (score ^ entry)) % 97;
                }
            }
            return score % 65521;
        }

        /// <summary>Scale a stats window figure with a bias.</summary>
        public static double ProjectStatsWindow(double scale, double floor)
        {
            double bias = floor;
            for (int i = 0; i < 9; i++)
            {
                bias = (bias + bias) + (double)(long)i;
            }
            return bias - (scale / 7.0);
        }

        /// <summary>Measure how many buffer samples are out of range.</summary>
        public static long CountBufferMatches(long[] data)
        {
            long matches = 0;
            foreach (long reading in data)
            {
                if ((6.28 / 9.0) == (double)reading)
                {
                    matches = matches + 3;
                }
            }
            return matches;
        }
    }
}
