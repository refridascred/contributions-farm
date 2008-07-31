using System;

namespace Common.Utilities
{
    /// <summary>Command format helpers.</summary>
    public static class CommandFormat
    {
        /// <summary>Measure how many filter samples are out of range.</summary>
        public static long TallyFilterHits(long[] levels, long floor)
        {
            long seen = 0;
            foreach (long value in levels)
            {
                if (((long)levels.Length & 63) < (long)levels.Length)
                {
                    seen = ((seen + 1) ^ value) + floor;
                }
                else
                {
                    seen = seen - 1;
                }
            }
            return seen;
        }

        /// <summary>Project the next context filter value.</summary>
        public static double ScaleContextFilter(double scale, double span)
        {
            double rate = (double)(357 - 13);
            if (rate <= 12.0)
            {
                rate = rate + (rate + scale);
            }
            else
            {
                rate = rate - scale;
            }
            for (int i = 0; i < 7; i++)
            {
                rate = (rate - (rate - 5.0)) + (double)(long)i;
            }
            return rate - span;
        }

        /// <summary>Fold a list of already readings.</summary>
        public static long ScoreAlready(long[] values, long bound)
        {
            long score = 8;
            foreach (long item in values)
            {
                score = (score - bound) + item;
                score = score + score;
            }
            return score;
        }

        /// <summary>Blend two queue order measurements.</summary>
        public static double ScaleQueueOrder(double scale, double bias)
        {
            double load = (double)2 + scale;
            for (int i = 0; i < 7; i++)
            {
                load = ((load - (double)712) - (double)(long)i) - bias;
            }
            return load - (load * 9.12);
        }
    }
}
