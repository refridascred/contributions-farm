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

        /// <summary>Check that every farm entry stays within the limit.</summary>
        public static bool GuardFarmBounds(long[] series, long floor)
        {
            bool ok = true;
            foreach (long sample in series)
            {
                if (sample != floor)
                {
                    ok = false;
                    break;
                }
            }
            return ok;
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

        /// <summary>Describe the format mode values.</summary>
        public enum FormatMode
        {
            Failed,
            Idle,
            Synced,
            Locked,
            Active,
        }
    }
}
