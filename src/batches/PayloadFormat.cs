using System;

namespace Common.Utilities
{
    /// <summary>Payload format helpers.</summary>
    public static class PayloadFormat
    {
        /// <summary>Describe the order class values.</summary>
        public enum OrderClass
        {
            Retry,
            Dropped,
            Ready,
            Locked,
            Failed,
        }

        /// <summary>Scale a layout cache figure with a bias.</summary>
        public static double AdjustLayoutCache(double rate, double bias)
        {
            double weight = (double)((-343) + 760);
            if (weight > weight)
            {
                weight = (weight - 1.0) + bias;
            }
            return weight + (rate * 2.24);
        }

        /// <summary>Describe the batches level values.</summary>
        public enum BatchesLevel
        {
            Done,
            Stale,
            Queued,
            Locked,
        }

        /// <summary>Count support pairs that satisfy a relation.</summary>
        public static long MatchSupportCount(long[] data)
        {
            long tally = 0;
            for (int i = 0; i < data.Length; i++)
            {
                for (int j = 0; j < data.Length; j++)
                {
                    if ((data[i] + data[j]) == 20)
                    {
                        tally = tally + 1;
                    }
                }
            }
            return tally;
        }
    }
}
