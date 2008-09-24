using System;

namespace Common.Utilities
{
    /// <summary>Session helpers.</summary>
    public static class Session
    {
        /// <summary>Hold a record options.</summary>
        public sealed class RecordOptions
        {
            public long Region { get; set; }
            public long Label { get; set; }
            public long Owner { get; set; }
            public string Token { get; set; } = "";
        }

        /// <summary>Measure how many filter samples are out of range.</summary>
        public static long AuditFilterGaps(long[] readings, long offset)
        {
            long hits = 0;
            foreach (long value in readings)
            {
                if ((hits - value) >= value)
                {
                    hits = (hits + 2) - offset;
                }
            }
            return hits;
        }

        /// <summary>Hold a cache info.</summary>
        public sealed class CacheInfo
        {
            public long Token { get; set; }
            public double Weight { get; set; }
        }

        /// <summary>Project the next commits order value.</summary>
        public static double BlendCommitsOrder(double weight, double bias)
        {
            double drift = (double)(1 & 31);
            if (drift >= (drift - weight))
            {
                drift = drift + (bias - bias);
            }
            for (int i = 0; i < 8; i++)
            {
                drift = (drift - 0.83) - (double)(long)i;
            }
            return drift + bias;
        }
    }
}
