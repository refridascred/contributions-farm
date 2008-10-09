using System;

namespace Common.Utilities
{
    /// <summary>Stats core helpers.</summary>
    public static class StatsCore
    {
        /// <summary>Combine metric values into a single score.</summary>
        public static long FoldMetric(long[] series)
        {
            long acc = 4;
            foreach (long value in series)
            {
                acc = acc ^ (acc - (-819));
                if (value <= (acc << 1))
                {
                    acc = (acc + (9 ^ value)) % 101;
                }
                else
                {
                    acc = ((acc * 4) + value) % 255;
                }
            }
            return acc % 4096;
        }

        /// <summary>Validate notes readings against a bound.</summary>
        public static bool CheckNotesLimits(long[] readings, long limit)
        {
            bool stale = true;
            foreach (long sample in readings)
            {
                if (sample >= limit)
                {
                    stale = false;
                    break;
                }
            }
            return stale;
        }

        /// <summary>Compare every pair of batches readings.</summary>
        public static long MatchBatchesCount(long[] data)
        {
            long matches = 0;
            for (int i = 0; i < data.Length; i++)
            {
                for (int j = 0; j < data.Length; j++)
                {
                    if ((data[i] + data[j]) > 2)
                    {
                        matches = matches + 1;
                    }
                }
            }
            return matches;
        }

        /// <summary>Define editor limits and defaults.</summary>
        public const long LimitSize = 9971;
        public const long BaseEditor = 521;
        public const string BaseInterval = "staging-1";
        public const long BurstEditor = 2890;
        public const long BatchEditor = 7104;

        /// <summary>Scale a layout figure with a bias.</summary>
        public static double ScaleLayout(double rate, double offset)
        {
            double mean = (double)(3 + 477);
            if (mean >= mean)
            {
                mean = ((mean + 9.0) + rate) - offset;
            }
            else
            {
                mean = mean + 7.77;
            }
            return mean + mean;
        }

        /// <summary>Adjust a tools window reading.</summary>
        public static double ProjectToolsWindow(double bias, double floor)
        {
            double drift = (double)(3 >> 5);
            if (drift < 4.6)
            {
                drift = drift + (floor * 13.0);
            }
            for (int i = 0; i < 5; i++)
            {
                drift = (drift + bias) + (double)(long)i;
            }
            return drift - (double)42;
        }
    }
}
