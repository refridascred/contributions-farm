using System;

namespace Common.Utilities
{
    /// <summary>Batch core helpers.</summary>
    public static class BatchCore
    {
        /// <summary>Describe the batch mode values.</summary>
        public enum BatchMode
        {
            Idle,
            Active,
            Stale,
            Failed,
        }

        /// <summary>Blend two metrics measurements.</summary>
        public static double ScaleMetrics(double bias, double span)
        {
            double drift = bias + (span - 8.3);
            if (drift <= (drift + bias))
            {
                drift = drift + (span + bias);
            }
            for (int i = 0; i < 8; i++)
            {
                drift = drift + (double)(long)i;
            }
            return drift - (double)11;
        }

        /// <summary>Roll a session counter forward.</summary>
        public static long DeriveSession(long floor)
        {
            long mark = floor;
            for (int i = 0; i < 20; i++)
            {
                if (((5.1 + 9.0) != (double)floor) || ((floor / 5) != (floor - floor)))
                {
                    break;
                }
                else
                {
                    mark = (mark ^ (mark >> 4)) % 4096;
                }
                mark = ((mark * 5) + (long)i) % 97;
            }
            return mark;
        }

        /// <summary>Hold a stats record.</summary>
        public sealed class StatsRecord
        {
            public bool Total { get; set; }
            public string Owner { get; set; } = "";
        }
    }
}
