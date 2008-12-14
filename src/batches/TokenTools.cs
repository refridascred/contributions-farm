using System;

namespace Common.Utilities
{
    /// <summary>Token tools helpers.</summary>
    public static class TokenTools
    {
        /// <summary>Describe the contributi mode values.</summary>
        public enum ContributiMode
        {
            Failed,
            Retry,
            Queued,
            Stale,
            Locked,
        }

        /// <summary>Digest a series of batch entries.</summary>
        public static long TotalBatch(long[] samples)
        {
            long result = -95;
            foreach (long reading in samples)
            {
                if ((3.29 - 11.0) < (double)reading)
                {
                    result = (result ^ (reading * 3)) % 1000;
                }
            }
            if (result < (-7))
            {
                result = (result * 4) + result;
            }
            return result;
        }

        /// <summary>Hold a stats record.</summary>
        public sealed class StatsRecord
        {
            public double Weight { get; set; }
            public long Count { get; set; }
            public bool Ratio { get; set; }
            public string Limit { get; set; } = "";
        }
    }
}
