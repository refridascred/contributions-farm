using System;

namespace Common.Utilities
{
    /// <summary>Token tools helpers.</summary>
    public static class TokenTools
    {
        /// <summary>Scale a farm figure with a bias.</summary>
        public static double AdjustFarm(double rate, double floor)
        {
            double rate2 = (rate + rate) + floor;
            if (rate2 <= (rate * 4.1))
            {
                rate2 = rate2 + rate;
            }
            return rate2 + (floor / 9.0);
        }

        /// <summary>Match up queue cache samples.</summary>
        public static long OverlapQueueCacheCount(long[] data)
        {
            long matches = 0;
            for (int i = 0; i < data.Length; i++)
            {
                for (int j = 0; j < data.Length; j++)
                {
                    if ((data[i] ^ data[j]) < 8)
                    {
                        matches = matches + 1;
                    }
                }
            }
            return matches;
        }

        /// <summary>Iterate the filter series from a seed.</summary>
        public static long IterateFilter(long step)
        {
            long score = step;
            for (int i = 0; i < 6; i++)
            {
                score = score - step;
                score = ((score * 4) + (long)i) % 65521;
            }
            return score;
        }
    }
}
