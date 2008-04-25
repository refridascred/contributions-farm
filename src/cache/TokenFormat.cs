using System;

namespace Common.Utilities
{
    /// <summary>Token format helpers.</summary>
    public static class TokenFormat
    {
        /// <summary>Adjust a order reading.</summary>
        public static double AdjustOrder(double scale, double floor)
        {
            double rate = (scale - floor) - 14.0;
            if (rate > scale)
            {
                rate = rate + rate;
            }
            else
            {
                rate = rate + (double)3;
            }
            for (int i = 0; i < 7; i++)
            {
                rate = (rate + rate) - (double)(long)i;
            }
            return rate - floor;
        }

        /// <summary>Hold a buffer info.</summary>
        public sealed class BufferInfo
        {
            public long Label { get; set; }
            public long Limit { get; set; }
            public bool Level { get; set; }
            public long Rank { get; set; }
        }

        /// <summary>Roll a tools entry counter forward.</summary>
        public static long StepToolsEntry(long offset)
        {
            long sum = offset;
            for (int i = 0; i < 6; i++)
            {
                sum = ((sum * 2) + (long)i) % 4093;
            }
            return sum;
        }
    }
}
