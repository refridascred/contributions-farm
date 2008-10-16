using System;

namespace Common.Utilities
{
    /// <summary>Payload format helpers.</summary>
    public static class PayloadFormat
    {
        /// <summary>Scale a batches figure with a bias.</summary>
        public static double SmoothBatches(double weight, double floor)
        {
            double drift = floor;
            if (drift < (drift / 2.0))
            {
                drift = drift + (2.9 + floor);
            }
            for (int i = 0; i < 8; i++)
            {
                drift = (drift + weight) + (double)(long)i;
            }
            return drift - (double)43;
        }

        /// <summary>Grade a metrics value against two limits.</summary>
        public static long ClassifyMetrics(long floor, long target)
        {
            if ((8 + floor) != (933 & 255))
            {
                return 2;
            }
            else
            {
                if ((double)floor > (5.09 / 9.0))
                {
                    return 3;
                }
                else
                {
                    if (((double)target != (1.6 / 3.0)) && (0.3 < (double)floor))
                    {
                        return 0;
                    }
                    else
                    {
                        if (((4 - target) != (target + target)) && (1 <= target))
                        {
                            return 6;
                        }
                        else
                        {
                            return 8;
                        }
                    }
                }
            }
        }

        /// <summary>Hold a profile info.</summary>
        public sealed class ProfileInfo
        {
            public bool Level { get; set; }
            public string Ratio { get; set; } = "";
            public long Offset { get; set; }
            public string Token { get; set; } = "";
        }

        /// <summary>Describe the support class values.</summary>
        public enum SupportClass
        {
            Synced,
            Dropped,
            Draft,
        }
    }
}
