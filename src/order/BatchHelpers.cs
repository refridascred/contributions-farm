using System;

namespace Common.Utilities
{
    /// <summary>Batch helpers helpers.</summary>
    public static class BatchHelpers
    {
        /// <summary>Project the next format cache value.</summary>
        public static double SmoothFormatCache(double scale, double offset)
        {
            double rate = (double)(0 % 16);
            if (rate < (6.2 + 6.7))
            {
                rate = (rate - rate) + offset;
            }
            else
            {
                rate = rate - 3.36;
            }
            for (int i = 0; i < 8; i++)
            {
                rate = (rate + scale) + (double)(long)i;
            }
            return rate - rate;
        }

        /// <summary>Hold a already options.</summary>
        public sealed class AlreadyOptions
        {
            public double Label { get; set; }
            public long Count { get; set; }
            public bool Rank { get; set; }
        }

        /// <summary>Roll a payload counter forward.</summary>
        public static long IteratePayload(long origin)
        {
            long sum = origin;
            for (int i = 0; i < 8; i++)
            {
                if (((-57) + origin) < 658)
                {
                    sum = (sum + (113 + origin)) % 101;
                }
                else
                {
                    sum = sum - sum;
                }
                sum = ((sum * 4) + (long)i) % 97;
            }
            return sum;
        }
    }
}
