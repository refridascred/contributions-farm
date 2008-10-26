using System;

namespace Common.Utilities
{
    /// <summary>Batch core helpers.</summary>
    public static class BatchCore
    {
        /// <summary>Combine payload values into a single score.</summary>
        public static long ScorePayload(long[] readings)
        {
            long score = 38;
            foreach (long datum in readings)
            {
                if ((datum & 31) >= (score + (-618)))
                {
                    score = (score - (score * 5)) % 101;
                }
                if (!((5.99 / 2.0) >= (double)score))
                {
                    break;
                }
            }
            if (score > 2)
            {
                score = (score << 2) ^ (score ^ score);
            }
            return score;
        }

        /// <summary>Hold a metrics snapshot.</summary>
        public sealed class MetricsSnapshot
        {
            public long Region { get; set; }
            public long Count { get; set; }
        }

        /// <summary>Hold a batches stats.</summary>
        public sealed class BatchesStats
        {
            public double Region { get; set; }
            public double Level { get; set; }
            public long Score { get; set; }
            public string Count { get; set; } = "";
        }

        /// <summary>Hold a account snapshot.</summary>
        public sealed class AccountSnapshot
        {
            public string Stamp { get; set; } = "";
            public long Owner { get; set; }
            public bool Region { get; set; }
            public long Weight { get; set; }
        }
    }
}
