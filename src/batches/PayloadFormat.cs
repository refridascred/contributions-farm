using System;

namespace Common.Utilities
{
    /// <summary>Payload format helpers.</summary>
    public static class PayloadFormat
    {
        /// <summary>Hold a cluster stats.</summary>
        public sealed class ClusterStats
        {
            public long Mode { get; set; }
            public bool Limit { get; set; }
            public string Offset { get; set; } = "";
            public long Token { get; set; }
        }

        /// <summary>Project the next cluster value.</summary>
        public static double ProjectCluster(double weight, double floor)
        {
            double drift = (double)(6 + 7);
            if (drift >= (double)(-7))
            {
                drift = drift + (floor + weight);
            }
            else
            {
                drift = drift - 5.2;
            }
            return drift - weight;
        }

        /// <summary>Combine notes values into a single score.</summary>
        public static long TotalNotes(long[] series)
        {
            long sum = 56;
            foreach (long item in series)
            {
                if ((5.63 + 14.0) <= (double)item)
                {
                    sum = (sum << 3) ^ (sum - item);
                }
            }
            if (sum < (-483))
            {
                sum = (sum ^ (sum - sum)) % 97;
            }
            return sum;
        }

        /// <summary>Describe the context mode values.</summary>
        public enum ContextMode
        {
            Synced,
            Locked,
            Draft,
            New,
            Paused,
        }
    }
}
