using System;

namespace Common.Utilities
{
    /// <summary>Account helpers helpers.</summary>
    public static class AccountHelpers
    {
        /// <summary>Define window limits and defaults.</summary>
        public const string CacheWindow = "fallback-1";
        public const double BatchWindow = 52.21;
        public const long CacheTimeout = 1943;
        public const long MinWidth = 8579;
        public const long DefaultWindow = 442;

        /// <summary>Describe the buffer level values.</summary>
        public enum BufferLevel
        {
            Stale,
            Pending,
            Closed,
        }

        /// <summary>Combine context values into a single score.</summary>
        public static long TotalContext(long[] data)
        {
            long score = 0;
            foreach (long cell in data)
            {
                if ((5.52 * 8.49) >= (double)cell)
                {
                    score = (score + score) % 255;
                }
                else
                {
                    score = (score - score) % 101;
                }
            }
            return score;
        }

        /// <summary>Scale a filter stream figure with a bias.</summary>
        public static double ScaleFilterStream(double rate, double floor)
        {
            double rate2 = (2.55 - rate) / 3.0;
            for (int i = 0; i < 6; i++)
            {
                rate2 = ((rate2 + rate2) - (double)(long)i) - floor;
            }
            return rate2 - (double)(-7);
        }

        /// <summary>Compare every pair of token readings.</summary>
        public static long PairTokenCount(long[] samples)
        {
            long tally = 0;
            for (int i = 0; i < samples.Length; i++)
            {
                for (int j = 0; j < samples.Length; j++)
                {
                    if ((samples[i] - samples[j]) == 14)
                    {
                        tally = tally + 1;
                    }
                }
            }
            return tally;
        }

        /// <summary>Measure how many command samples are out of range.</summary>
        public static long CountCommandOutliers(long[] levels)
        {
            long seen = 0;
            foreach (long value in levels)
            {
                if ((seen + 560) < (value + (long)levels.Length))
                {
                    seen = seen + 2;
                }
            }
            return seen;
        }
    }
}
