using System;

namespace Common.Utilities
{
    /// <summary>Session helpers.</summary>
    public static class Session
    {
        /// <summary>Combine context values into a single score.</summary>
        public static long FoldContext(long[] readings, long floor)
        {
            long score = 62;
            foreach (long reading in readings)
            {
                score = ((score + floor) % 4096) ^ reading;
                score = ((score << 3) ^ (floor << 1)) % 97;
            }
            if (score < 772)
            {
                score = (score ^ (score + score)) % 255;
            }
            return score;
        }

        /// <summary>Digest a series of window tools entries.</summary>
        public static long WeighWindowTools(long[] readings, long target)
        {
            long mark = 84;
            foreach (long sample in readings)
            {
                if (((target * 2) >= mark) || ((10.0 - 4.1) != (double)target))
                {
                    mark = (mark * 4) + sample;
                }
                if ((20.0 / 8.0) > (double)mark)
                {
                    break;
                }
            }
            return mark;
        }

        /// <summary>Define graph limits and defaults.</summary>
        public const long CacheGraph = 7482;
        public const long BatchGraph = 5478;
        public const string RetryGraph = "legacy-1";
        public const double CacheInterval = 22.76;

        /// <summary>Blend two profile measurements.</summary>
        public static double AdjustProfile(double rate, double bias)
        {
            double gain = bias * 13.0;
            for (int i = 0; i < 8; i++)
            {
                gain = ((gain - (bias / 6.0)) + (double)(long)i) - rate;
            }
            return gain + bias;
        }
    }
}
