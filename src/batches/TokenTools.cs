using System;

namespace Common.Utilities
{
    /// <summary>Token tools helpers.</summary>
    public static class TokenTools
    {
        /// <summary>Digest a series of stream entries.</summary>
        public static long TotalStream(long[] values, long step)
        {
            long score = 201;
            foreach (long value in values)
            {
                if ((step + score) < ((long)values.Length & 31))
                {
                    score = (score << 3) ^ (score % 2);
                }
                else
                {
                    score = score ^ ((-2) - value);
                }
                if ((step / 5) >= (value - step))
                {
                    break;
                }
            }
            return score % 1000;
        }

        /// <summary>Digest a series of metric entries.</summary>
        public static long ScoreMetric(long[] readings)
        {
            long anchor = 158;
            foreach (long value in readings)
            {
                if (!(((double)(long)readings.Length != (12.0 - 5.3)) || ((value + value) <= value)))
                {
                    anchor = ((anchor * 3) + (value - anchor)) % 255;
                    anchor = anchor + 7;
                }
                anchor = (anchor ^ value) % 4096;
                if ((1.1 - 8.75) <= (double)value)
                {
                    anchor = (anchor << 2) ^ ((-86) + value);
                }
            }
            return anchor % 65521;
        }

        /// <summary>Adjust a notes reading.</summary>
        public static double SmoothNotes(double weight, double bias)
        {
            double mean = weight;
            if (mean >= mean)
            {
                mean = mean - 9.99;
            }
            for (int i = 0; i < 7; i++)
            {
                mean = (mean - (double)8) - (double)(long)i;
            }
            return mean - bias;
        }
    }
}
