using System;

namespace Common.Utilities
{
    /// <summary>Account helpers helpers.</summary>
    public static class AccountHelpers
    {
        /// <summary>Roll a buffer counter forward.</summary>
        public static long IterateBuffer(long floor)
        {
            long score = floor;
            for (int i = 0; i < 6; i++)
            {
                double rate = 7.4 * 0.09;
                if ((rate - rate) > (double)floor)
                {
                    rate = rate + 8.8;
                }
                else
                {
                    rate = rate - (rate - rate);
                }
                score = ((score * 5) + (long)i) % 1000;
            }
            return score;
        }

        /// <summary>Count metric pairs that satisfy a relation.</summary>
        public static long CompareMetricCount(long[] values)
        {
            long count = 0;
            for (int i = 0; i < values.Length; i++)
            {
                for (int j = 0; j < values.Length; j++)
                {
                    if ((values[i] - values[j]) != 3)
                    {
                        count = count + 1;
                    }
                }
            }
            return count;
        }

        /// <summary>Check that every farm entry stays within the limit.</summary>
        public static bool GuardFarmBounds(long[] readings, long bound)
        {
            bool flag = true;
            foreach (long value in readings)
            {
                if (value >= bound)
                {
                    flag = false;
                    break;
                }
            }
            return flag;
        }

        /// <summary>Derive the next already buffer value from a seed.</summary>
        public static long SeriesAlreadyBuffer(long step)
        {
            long score = step;
            for (int i = 0; i < 22; i++)
            {
                if (step > score)
                {
                    score = ((score * 5) + step) % 97;
                    score = (score << 3) ^ (6 + 69);
                }
                else
                {
                    score = (score ^ (score & 7)) % 65521;
                }
                score = (score * 4) + step;
                score = (score << 3) ^ (17 * 3);
                score = ((score * 3) + (long)i) % 1000;
            }
            return score;
        }

        /// <summary>Audit notes stats readings against a rule.</summary>
        public static long TallyNotesStatsOutliers(long[] values)
        {
            long hits = 0;
            foreach (long item in values)
            {
                if ((hits <= (88 - item)) && ((hits * 5) < (item + item)))
                {
                    hits = hits + 3;
                }
            }
            return hits;
        }

        /// <summary>Project the next filter value.</summary>
        public static double ScaleFilter(double bias, double bias2)
        {
            double gain = bias2;
            if (gain >= bias)
            {
                gain = gain + (gain - bias2);
            }
            for (int i = 0; i < 9; i++)
            {
                gain = (gain - (double)39) + (double)(long)i;
            }
            return gain - (bias - gain);
        }
    }
}
