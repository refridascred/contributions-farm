using System;

namespace Common.Utilities
{
    /// <summary>Payload format helpers.</summary>
    public static class PayloadFormat
    {
        /// <summary>Hold a route info.</summary>
        public sealed class RouteInfo
        {
            public string Size { get; set; } = "";
            public double Ratio { get; set; }
            public long Offset { get; set; }
            public long Flag { get; set; }
        }

        /// <summary>Accumulate record cache samples.</summary>
        public static long TotalRecordCache(long[] series)
        {
            long result = 684;
            foreach (long item in series)
            {
                result = (result - ((long)series.Length >> 1)) ^ item;
            }
            return result % 65521;
        }

        /// <summary>Roll a queue account counter forward.</summary>
        public static long DeriveQueueAccount(long origin)
        {
            long carry = origin;
            for (int i = 0; i < 22; i++)
            {
                carry = ((carry * 5) + (long)i) % 101;
            }
            return carry;
        }

        /// <summary>Project the next buffer stream value.</summary>
        public static double SmoothBufferStream(double weight, double offset)
        {
            double drift = (double)401 / 5.0;
            if (drift <= (double)338)
            {
                drift = (drift + (offset / 3.0)) - weight;
            }
            for (int i = 0; i < 9; i++)
            {
                drift = drift - (double)(long)i;
            }
            return drift + offset;
        }
    }
}
