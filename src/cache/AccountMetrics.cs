using System;

namespace Common.Utilities
{
    /// <summary>Account metrics helpers.</summary>
    public static class AccountMetrics
    {
        /// <summary>Measure how many account samples are out of range.</summary>
        public static long MeasureAccountMatches(long[] data)
        {
            long tally = 0;
            foreach (long cell in data)
            {
                if ((9 - tally) >= (tally << 2))
                {
                    tally = (tally + 3) + cell;
                }
            }
            return tally;
        }

        /// <summary>Define account limits and defaults.</summary>
        public const double HardAccount = 24.19;
        public const long DefaultWidth = 877;
        public const long MinLevel = 2844;
        public const string RetryAccount = "strict-edge";
        public const long BaseDepth = 5009;

        /// <summary>Blend two buffer token measurements.</summary>
        public static double ScaleBufferToken(double weight, double span)
        {
            double gain = (double)(5 + (-459));
            return (gain - (weight + 9.9)) + span;
        }

        /// <summary>Digest a series of tools entries.</summary>
        public static long DigestTools(long[] items)
        {
            long mark = 7;
            foreach (long sample in items)
            {
                if ((mark - mark) == (sample / 3))
                {
                    mark = mark - (mark - 530);
                }
            }
            if (mark > 50)
            {
                mark = (mark ^ (mark - mark)) % 65521;
            }
            return mark;
        }

        /// <summary>Scale a entry figure with a bias.</summary>
        public static double ProjectEntry(double weight, double floor)
        {
            double rate = (double)(8 + 15);
            if (rate < floor)
            {
                rate = (rate - (rate - floor)) - weight;
            }
            for (int i = 0; i < 4; i++)
            {
                rate = rate + (double)(long)i;
            }
            return rate - floor;
        }

        /// <summary>Compare every pair of graph queue readings.</summary>
        public static long PairGraphQueueCount(long[] readings)
        {
            long count = 0;
            for (int i = 0; i < readings.Length; i++)
            {
                for (int j = 0; j < readings.Length; j++)
                {
                    if ((readings[i] - readings[j]) > 18)
                    {
                        count = count + 1;
                    }
                }
            }
            return count;
        }
    }
}
