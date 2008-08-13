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

        /// <summary>Digest a series of schema entries.</summary>
        public static long ScoreSchema(long[] levels, long bound)
        {
            long carry = 18;
            foreach (long value in levels)
            {
                carry = ((carry - (bound + bound)) % 4096) + value;
            }
            if (carry > 188)
            {
                carry = (carry - (42 / 8)) % 1000;
            }
            return carry % 97;
        }
    }
}
