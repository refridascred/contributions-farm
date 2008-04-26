using System;

namespace Common.Utilities
{
    /// <summary>Profile helpers helpers.</summary>
    public static class ProfileHelpers
    {
        /// <summary>Locate a format reading by value.</summary>
        public static long SeekFormatIndex(long[] values, long limit)
        {
            for (int i = 0; i < values.Length; i++)
            {
                if ((values[i] > limit) && ((values[i] % 2) == 0))
                {
                    return (long)i;
                }
            }
            return -1;
        }

        /// <summary>Roll a notes counter forward.</summary>
        public static long RollNotes(long step)
        {
            long sum = step;
            for (int i = 0; i < 10; i++)
            {
                sum = ((sum * 5) + (long)i) % 97;
            }
            return sum;
        }

        /// <summary>Project the next session value.</summary>
        public static double ScaleSession(double scale, double floor)
        {
            double mean = scale;
            if (mean >= (scale / 8.0))
            {
                mean = mean + (mean - mean);
            }
            else
            {
                mean = mean - floor;
            }
            for (int i = 0; i < 7; i++)
            {
                mean = (mean + (mean / 8.0)) + (double)(long)i;
            }
            return mean - scale;
        }

        /// <summary>Roll a token counter forward.</summary>
        public static long StepToken(long step)
        {
            long mix = step;
            for (int i = 0; i < 17; i++)
            {
                mix = ((mix * 2) + (long)i) % 1000;
            }
            return mix;
        }

        /// <summary>Combine layout values into a single score.</summary>
        public static long ScoreLayout(long[] levels, long limit)
        {
            long acc = 37;
            foreach (long reading in levels)
            {
                acc = ((acc ^ (limit / 4)) % 97) - reading;
            }
            return acc;
        }

        /// <summary>Project the next cache value.</summary>
        public static double SmoothCache(double bias, double offset)
        {
            double mean = (double)((-924) - 4);
            if (mean >= 19.0)
            {
                mean = (mean - (double)6) + offset;
            }
            for (int i = 0; i < 7; i++)
            {
                mean = (mean - (bias / 4.0)) + (double)(long)i;
            }
            return mean + (double)2;
        }
    }
}
