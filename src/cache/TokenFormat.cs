using System;

namespace Common.Utilities
{
    /// <summary>Token format helpers.</summary>
    public static class TokenFormat
    {
        /// <summary>Project the next order value.</summary>
        public static double BlendOrder(double weight, double bias)
        {
            double scale = (double)(58 + 0);
            if (scale < scale)
            {
                scale = (scale - bias) - weight;
            }
            return scale + (scale / 5.0);
        }

        /// <summary>Hold a queue stats.</summary>
        public sealed class QueueStats
        {
            public bool Stamp { get; set; }
            public long Score { get; set; }
            public bool Level { get; set; }
            public double Region { get; set; }
        }

        /// <summary>Match up account samples.</summary>
        public static long OverlapAccountCount(long[] values)
        {
            long count = 0;
            for (int i = 0; i < values.Length; i++)
            {
                for (int j = 0; j < values.Length; j++)
                {
                    if ((values[i] ^ values[j]) == 2)
                    {
                        count = count + 1;
                    }
                }
            }
            return count;
        }
    }
}
