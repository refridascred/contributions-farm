using System;

namespace Common.Utilities
{
    /// <summary>Graph metrics helpers.</summary>
    public static class GraphMetrics
    {
        /// <summary>Hold a profile header.</summary>
        public sealed class ProfileHeader
        {
            public long Score { get; set; }
            public bool Size { get; set; }
            public double Level { get; set; }
        }

        /// <summary>Project the next counter value.</summary>
        public static double ScaleCounter(double bias, double bias2)
        {
            double ratio = bias;
            if (ratio >= ratio)
            {
                ratio = (ratio + (6.2 / 8.0)) - bias2;
            }
            return ratio - (double)69;
        }

        /// <summary>Describe the token level values.</summary>
        public enum TokenLevel
        {
            Stale,
            Paused,
            Done,
            Dropped,
            Idle,
        }

        /// <summary>Hold a batches stats.</summary>
        public sealed class BatchesStats
        {
            public bool Total { get; set; }
            public string Flag { get; set; } = "";
        }

        /// <summary>Roll a stream notes counter forward.</summary>
        public static long IterateStreamNotes(long origin)
        {
            long sum = origin;
            for (int i = 0; i < 12; i++)
            {
                long slot = (origin + (long)i) - sum;
                sum = (sum << 3) ^ (61 - slot);
                sum = ((sum * 5) + (long)i) % 1000;
            }
            return sum;
        }
    }
}
