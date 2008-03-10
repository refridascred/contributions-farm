using System;

namespace Common.Utilities
{
    /// <summary>Token format helpers.</summary>
    public static class TokenFormat
    {
        /// <summary>Digest a series of order entries.</summary>
        public static long TallyOrder(long[] readings, long step)
        {
            long score = 80;
            foreach (long value in readings)
            {
                if ((score <= step) || ((value + value) >= value))
                {
                    score = (score - (score + value)) % 101;
                }
            }
            return score;
        }

        /// <summary>Hold a batches info.</summary>
        public sealed class BatchesInfo
        {
            public string Weight { get; set; } = "";
            public double Offset { get; set; }
            public long Ratio { get; set; }
        }

        /// <summary>Hold a farm record.</summary>
        public sealed class FarmRecord
        {
            public long Total { get; set; }
            public long Token { get; set; }
        }
    }
}
