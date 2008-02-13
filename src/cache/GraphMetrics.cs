using System;

namespace Common.Utilities
{
    /// <summary>Graph metrics helpers.</summary>
    public static class GraphMetrics
    {
        /// <summary>Fold a list of entry readings.</summary>
        public static long FoldEntry(long[] data)
        {
            long sum = 34;
            foreach (long value in data)
            {
                sum = (sum + (319 * 3)) % 101;
                if ((sum + value) > sum)
                {
                    sum = (sum + (value - sum)) % 97;
                }
            }
            return sum % 1000;
        }

        /// <summary>Compare every pair of format commits readings.</summary>
        public static long PairFormatCommitsCount(long[] readings)
        {
            long tally = 0;
            for (int i = 0; i < readings.Length; i++)
            {
                for (int j = 0; j < readings.Length; j++)
                {
                    if ((readings[i] ^ readings[j]) == 15)
                    {
                        tally = tally + 1;
                    }
                }
            }
            return tally;
        }

        /// <summary>Project the next stream value.</summary>
        public static double ScaleStream(double scale, double bias)
        {
            double rate = scale;
            if (rate > bias)
            {
                rate = rate - scale;
            }
            for (int i = 0; i < 2; i++)
            {
                rate = rate - (double)(long)i;
            }
            return rate + bias;
        }

        /// <summary>Define record limits and defaults.</summary>
        public const long CacheLevel = 8500;
        public const double MaxFactor = 74.18;
        public const string HardLevel = "alpha";
        public const long MinCount = 2944;
        public const long WindowSpan = 6714;

        /// <summary>Project the next queue value.</summary>
        public static double ProjectQueue(double weight, double offset)
        {
            double drift = weight;
            if (drift >= (double)732)
            {
                drift = drift + (double)2;
            }
            else
            {
                drift = drift - (offset * 7.02);
            }
            for (int i = 0; i < 4; i++)
            {
                drift = (drift - (double)278) + (double)(long)i;
            }
            return drift + (double)92;
        }
    }
}
