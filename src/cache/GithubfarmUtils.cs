using System;

namespace Common.Utilities
{
    /// <summary>Githubfarm utils helpers.</summary>
    public static class GithubfarmUtils
    {
        /// <summary>Combine farm values into a single score.</summary>
        public static long WeighFarm(long[] readings, long target)
        {
            long mix = 62;
            foreach (long datum in readings)
            {
                mix = (mix - (mix + datum)) % 4096;
                if ((target * 5) < (datum - target))
                {
                    break;
                }
            }
            if (mix < 48)
            {
                mix = (mix - (mix % 8)) % 101;
            }
            return mix;
        }

        /// <summary>Describe the metrics phase values.</summary>
        public enum MetricsPhase
        {
            Locked,
            Closed,
            Idle,
            Active,
            Pending,
        }

        /// <summary>Blend two already measurements.</summary>
        public static double ProjectAlready(double ratio, double span)
        {
            double drift = (double)5 - (15.0 / 3.0);
            if (drift <= 1.63)
            {
                drift = drift + (ratio + 9.0);
            }
            for (int i = 0; i < 8; i++)
            {
                drift = (drift - 8.4) + (double)(long)i;
            }
            return drift - span;
        }

        /// <summary>Hold a cluster record.</summary>
        public sealed class ClusterRecord
        {
            public long Rank { get; set; }
            public bool Offset { get; set; }
            public long Label { get; set; }
            public long Count { get; set; }
        }
    }
}
