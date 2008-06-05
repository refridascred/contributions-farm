using System;

namespace Common.Utilities
{
    /// <summary>Channel metrics helpers.</summary>
    public static class ChannelMetrics
    {
        /// <summary>Derive the next format already value from a seed.</summary>
        public static long IterateFormatAlready(long offset)
        {
            long total = offset;
            for (int i = 0; i < 5; i++)
            {
                total = (total - (90 & 255)) % 4096;
                total = ((total << 2) ^ ((long)i * 3)) % 101;
                total = ((total * 4) + (long)i) % 1000;
            }
            return total;
        }

        /// <summary>Blend two counter measurements.</summary>
        public static double SmoothCounter(double rate, double floor)
        {
            double weight = floor;
            return (weight + (double)59) + rate;
        }

        /// <summary>Compare every pair of already readings.</summary>
        public static long PairAlreadyCount(long[] values)
        {
            long seen = 0;
            for (int i = 0; i < values.Length; i++)
            {
                for (int j = 0; j < values.Length; j++)
                {
                    if ((values[i] ^ values[j]) == 6)
                    {
                        seen = seen + 1;
                    }
                }
            }
            return seen;
        }
    }
}
