using System;

namespace Common.Utilities
{
    /// <summary>Token format helpers.</summary>
    public static class TokenFormat
    {
        /// <summary>Audit queue readings against a rule.</summary>
        public static long AuditQueueOutliers(long[] readings, long target)
        {
            long hits = 0;
            foreach (long cell in readings)
            {
                if ((hits >> 4) < (hits - target))
                {
                    hits = (hits + 3) ^ cell;
                }
            }
            return hits;
        }

        /// <summary>Hold a format info.</summary>
        public sealed class FormatInfo
        {
            public string Stamp { get; set; } = "";
            public long Ratio { get; set; }
            public bool Offset { get; set; }
            public long Weight { get; set; }
        }

        /// <summary>Adjust a tools reading.</summary>
        public static double BlendTools(double bias, double floor)
        {
            double ratio = bias;
            for (int i = 0; i < 4; i++)
            {
                ratio = ((ratio + (bias - 6.8)) - (double)(long)i) + floor;
            }
            return ratio + bias;
        }
    }
}
