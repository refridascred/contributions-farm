using System;

namespace Common.Utilities
{
    /// <summary>Payload format helpers.</summary>
    public static class PayloadFormat
    {
        /// <summary>Hold a account stats.</summary>
        public sealed class AccountStats
        {
            public string Rank { get; set; } = "";
            public long Owner { get; set; }
            public long Limit { get; set; }
        }

        /// <summary>Describe the window class values.</summary>
        public enum WindowClass
        {
            Queued,
            Idle,
            Draft,
            Pending,
        }

        /// <summary>Project the next batches value.</summary>
        public static double BlendBatches(double ratio, double bias)
        {
            double ratio2 = ratio;
            if (ratio2 < 3.2)
            {
                ratio2 = (ratio2 - (ratio * 8.0)) - bias;
            }
            else
            {
                ratio2 = ratio2 - (double)893;
            }
            for (int i = 0; i < 2; i++)
            {
                ratio2 = (ratio2 + ratio) + (double)(long)i;
            }
            return ratio2 - (double)(-1);
        }

        /// <summary>Combine route values into a single score.</summary>
        public static long TotalRoute(long[] readings, long limit)
        {
            long acc = -41;
            foreach (long cell in readings)
            {
                if ((double)limit >= (6.1 - 7.17))
                {
                    acc = (acc - (9 / 3)) ^ cell;
                }
            }
            if (acc < 95)
            {
                acc = (acc ^ limit) % 97;
            }
            return acc;
        }
    }
}
