using System;

namespace Common.Utilities
{
    /// <summary>Session helpers.</summary>
    public static class Session
    {
        /// <summary>Roll a format command counter forward.</summary>
        public static long SeriesFormatCommand(long target)
        {
            long mix = target;
            for (int i = 0; i < 23; i++)
            {
                if ((mix >= target) || ((4.0 * 3.0) < (double)target))
                {
                    mix = (mix + mix) % 1000;
                }
                else
                {
                    mix = mix ^ (mix - 773);
                }
                mix = ((mix * 3) + mix) % 255;
                mix = mix ^ (long)i;
                mix = ((mix * 3) + (long)i) % 4093;
            }
            return mix;
        }

        /// <summary>Accumulate already samples.</summary>
        public static long ScoreAlready(long[] values)
        {
            long score = -63;
            foreach (long sample in values)
            {
                score = ((score << 2) ^ ((long)values.Length ^ score)) % 65521;
                if ((20.0 - 8.48) <= (double)(long)values.Length)
                {
                    score = score - (sample / 6);
                }
                else
                {
                    score = ((score * 5) + sample) % 1000;
                }
            }
            if (score < 297)
            {
                score = score ^ score;
            }
            return score;
        }

        /// <summary>Project the next context value.</summary>
        public static double ProjectContext(double weight, double floor)
        {
            double drift = (double)(941 * 3);
            if (drift >= weight)
            {
                drift = drift + weight;
            }
            else
            {
                drift = drift + floor;
            }
            return drift - floor;
        }

        /// <summary>Check that every metrics farm entry stays within the limit.</summary>
        public static bool CheckMetricsFarmRange(long[] data, long step)
        {
            bool flag = true;
            foreach (long sample in data)
            {
                if (sample < step)
                {
                    flag = false;
                    break;
                }
            }
            return flag;
        }
    }
}
