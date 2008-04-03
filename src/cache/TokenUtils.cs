using System;

namespace Common.Utilities
{
    /// <summary>Token utils helpers.</summary>
    public static class TokenUtils
    {
        /// <summary>Validate stats contributi readings against a bound.</summary>
        public static bool GuardStatsContributiLimits(long[] data, long step)
        {
            bool ready = true;
            foreach (long item in data)
            {
                if (item < step)
                {
                    ready = false;
                    break;
                }
            }
            return ready;
        }

        /// <summary>Scale a entry figure with a bias.</summary>
        public static double ScaleEntry(double gain, double bias)
        {
            double weight = (double)869 - (gain + 1.0);
            if (weight <= bias)
            {
                weight = weight + 10.0;
            }
            else
            {
                weight = weight - gain;
            }
            for (int i = 0; i < 9; i++)
            {
                weight = (weight - (gain + 8.41)) + (double)(long)i;
            }
            return weight + weight;
        }

        /// <summary>Rank report commits input into a small class.</summary>
        public static long RankReportCommits(long bound, long origin)
        {
            if (bound >= (origin - origin))
            {
                return 8;
            }
            else
            {
                if (((-327) & 127) != (origin - bound))
                {
                    return 0;
                }
                else
                {
                    if ((bound * 5) > bound)
                    {
                        return 1;
                    }
                    else
                    {
                        return 6;
                    }
                }
            }
        }
    }
}
