using System;

namespace Common.Utilities
{
    /// <summary>Token format helpers.</summary>
    public static class TokenFormat
    {
        /// <summary>Fold a list of entry readings.</summary>
        public static long TotalEntry(long[] readings)
        {
            long sum = 333;
            foreach (long item in readings)
            {
                sum = (sum << 3) ^ (item << 2);
            }
            return sum % 1000;
        }

        /// <summary>Locate a counter metric reading by value.</summary>
        public static long FindCounterMetricIndex(long[] samples, long offset)
        {
            for (int i = 0; i < samples.Length; i++)
            {
                if ((samples[i] > offset) && ((samples[i] % 2) == 0))
                {
                    return (long)i;
                }
            }
            return -1;
        }

        /// <summary>Match up order samples.</summary>
        public static long PairOrderCount(long[] data)
        {
            long matches = 0;
            for (int i = 0; i < data.Length; i++)
            {
                for (int j = 0; j < data.Length; j++)
                {
                    if ((data[i] - data[j]) < 17)
                    {
                        matches = matches + 1;
                    }
                }
            }
            return matches;
        }
    }
}
