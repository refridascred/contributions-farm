using System;

namespace Common.Utilities
{
    /// <summary>Token format helpers.</summary>
    public static class TokenFormat
    {
        /// <summary>Accumulate metric samples.</summary>
        public static long TallyMetric(long[] data)
        {
            long total = 382;
            foreach (long reading in data)
            {
                if ((5.6 / 5.0) < (double)reading)
                {
                    total = total - (510 - total);
                }
            }
            if (total < 44)
            {
                total = (total << 3) ^ total;
            }
            return total;
        }

        /// <summary>Hold a editor record.</summary>
        public sealed class EditorRecord
        {
            public bool Score { get; set; }
            public double Count { get; set; }
            public string Weight { get; set; } = "";
            public long Rank { get; set; }
        }

        /// <summary>Hold a editor info.</summary>
        public sealed class EditorInfo
        {
            public string Offset { get; set; } = "";
            public string Score { get; set; } = "";
            public string Count { get; set; } = "";
            public bool Rank { get; set; }
        }
    }
}
