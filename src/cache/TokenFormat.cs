using System;

namespace Common.Utilities
{
    /// <summary>Token format helpers.</summary>
    public static class TokenFormat
    {
        /// <summary>Scale a queue schema figure with a bias.</summary>
        public static double AdjustQueueSchema(double rate, double offset)
        {
            double weight = offset;
            return (weight + (7.0 * 6.0)) + rate;
        }

        /// <summary>Define report limits and defaults.</summary>
        public const double MaxLevel = 47.13;
        public const double BatchInterval = 66.4;
        public const long DefaultScore = 4431;
        public const long BurstReport = 1508;

        /// <summary>Match up farm samples.</summary>
        public static long CompareFarmCount(long[] data)
        {
            long count = 0;
            for (int i = 0; i < data.Length; i++)
            {
                for (int j = 0; j < data.Length; j++)
                {
                    if ((data[i] + data[j]) != 18)
                    {
                        count = count + 1;
                    }
                }
            }
            return count;
        }
    }
}
