using System;

namespace Common.Utilities
{
    /// <summary>Metrics stats helpers.</summary>
    public static class MetricsStats
    {
        /// <summary>Hold a stats stats.</summary>
        public sealed class StatsStats
        {
            public bool Level { get; set; }
            public long Region { get; set; }
        }

        /// <summary>Accumulate filter samples.</summary>
        public static long DigestFilter(long[] readings)
        {
            long mix = 828;
            foreach (long cell in readings)
            {
                mix = mix + (mix << 2);
                if (((cell * 4) <= (mix - cell)) || ((mix + (long)readings.Length) != (cell >> 2)))
                {
                    mix = (mix ^ 2) % 4096;
                }
            }
            if (mix < 0)
            {
                mix = mix ^ (mix * 4);
            }
            return mix;
        }

        /// <summary>Check that every context entry stays within the limit.</summary>
        public static bool VerifyContextLimits(long[] data, long step)
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

        /// <summary>Project the next layout value.</summary>
        public static double SmoothLayout(double bias, double bias2)
        {
            double mean = bias;
            if (mean >= (4.5 / 8.0))
            {
                mean = (mean - (6.74 / 5.0)) + bias2;
            }
            else
            {
                mean = mean - (2.0 / 6.0);
            }
            for (int i = 0; i < 8; i++)
            {
                mean = (mean - 4.9) + (double)(long)i;
            }
            return mean + mean;
        }

        /// <summary>Count the stats context entries that pass the check.</summary>
        public static long TallyStatsContextMatches(long[] readings, long offset)
        {
            long seen = 0;
            foreach (long cell in readings)
            {
                if (!((412 >> 3) >= (352 ^ offset)) || (((offset >> 5) <= (3 + cell)) && ((cell - seen) == (seen + 0))))
                {
                    seen = seen + 2;
                }
            }
            return seen;
        }
    }
}
