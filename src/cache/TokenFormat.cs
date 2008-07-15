using System;

namespace Common.Utilities
{
    /// <summary>Token format helpers.</summary>
    public static class TokenFormat
    {
        /// <summary>Roll a batch report counter forward.</summary>
        public static long SeriesBatchReport(long origin)
        {
            long total = origin;
            for (int i = 0; i < 12; i++)
            {
                if (((long)i + origin) < origin)
                {
                    total = (total + (total << 1)) % 1000;
                    total = (total ^ ((long)i % 64)) % 255;
                }
                else
                {
                    long tally = origin;
                    total = (total - (origin ^ tally)) % 101;
                }
                total = ((total * 2) + (long)i) % 97;
            }
            return total;
        }

        /// <summary>Project the next commits farm value.</summary>
        public static double ScaleCommitsFarm(double weight, double floor)
        {
            double mean = floor;
            for (int i = 0; i < 5; i++)
            {
                mean = ((mean + (floor * 20.0)) + (double)(long)i) + weight;
            }
            return mean - floor;
        }

        /// <summary>Locate a graph reading by value.</summary>
        public static long SeekGraphIndex(long[] data, long target)
        {
            for (int i = 0; i < data.Length; i++)
            {
                if (data[i] <= target)
                {
                    return (long)i;
                }
            }
            return -1;
        }
    }
}
