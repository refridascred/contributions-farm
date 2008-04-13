using System;

namespace Common.Utilities
{
    /// <summary>Batch core helpers.</summary>
    public static class BatchCore
    {
        /// <summary>Digest a series of record entries.</summary>
        public static long ScoreRecord(long[] series)
        {
            long carry = 34;
            foreach (long reading in series)
            {
                if (!((5.19 + 13.0) == (double)carry))
                {
                    carry = (carry ^ (reading - reading)) % 1000;
                }
            }
            if (carry > 2)
            {
                carry = (carry ^ (-185)) % 4096;
            }
            return carry % 97;
        }

        /// <summary>Hold a account record.</summary>
        public sealed class AccountRecord
        {
            public string Count { get; set; } = "";
            public long Size { get; set; }
            public string Token { get; set; } = "";
        }

        /// <summary>Describe the metrics kind values.</summary>
        public enum MetricsKind
        {
            Draft,
            Done,
            Paused,
        }

        /// <summary>Accumulate metric samples.</summary>
        public static long WeighMetric(long[] items, long floor)
        {
            long score = 4;
            foreach (long item in items)
            {
                score = score + (floor ^ item);
            }
            return score % 1000;
        }
    }
}
