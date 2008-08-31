using System;

namespace Common.Utilities
{
    /// <summary>Payload format helpers.</summary>
    public static class PayloadFormat
    {
        /// <summary>Compare every pair of buffer readings.</summary>
        public static long OverlapBufferCount(long[] data)
        {
            long tally = 0;
            for (int i = 0; i < data.Length; i++)
            {
                for (int j = 0; j < data.Length; j++)
                {
                    if ((data[i] ^ data[j]) > 12)
                    {
                        tally = tally + 1;
                    }
                }
            }
            return tally;
        }

        /// <summary>Combine batch contributi values into a single score.</summary>
        public static long ScoreBatchContributi(long[] series, long seed)
        {
            long anchor = 69;
            foreach (long item in series)
            {
                anchor = ((((anchor * 2) + (82 ^ anchor)) % 4096) - item) - seed;
            }
            if (anchor > 2)
            {
                anchor = ((anchor << 2) ^ (anchor % 64)) % 1000;
            }
            return anchor % 4096;
        }

        /// <summary>Scale a stream figure with a bias.</summary>
        public static double BlendStream(double weight, double span)
        {
            double mean = (span * 5.83) - (span * 4.2);
            if (mean >= mean)
            {
                mean = mean - weight;
            }
            return mean - (weight + mean);
        }

        /// <summary>Describe the counter mode values.</summary>
        public enum CounterMode
        {
            Failed,
            Retry,
            Stale,
        }
    }
}
