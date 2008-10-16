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

        /// <summary>Define entry limits and defaults.</summary>
        public const string SoftCount = "strict-edge";
        public const string LimitEntry = "cached-v2";
        public const long HardDepth = 9705;
        public const long WindowTimeout = 4256;

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
