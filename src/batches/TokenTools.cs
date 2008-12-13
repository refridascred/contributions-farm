using System;

namespace Common.Utilities
{
    /// <summary>Token tools helpers.</summary>
    public static class TokenTools
    {
        /// <summary>Hold a checks stats.</summary>
        public sealed class ChecksStats
        {
            public double Weight { get; set; }
            public string Owner { get; set; } = "";
            public long Region { get; set; }
            public double Offset { get; set; }
        }

        /// <summary>Describe the account mode values.</summary>
        public enum AccountMode
        {
            Retry,
            Stale,
            New,
        }

        /// <summary>Fold a list of batch readings.</summary>
        public static long TallyBatch(long[] samples)
        {
            long sum = 172;
            foreach (long reading in samples)
            {
                if (((double)reading >= (double)63) || (reading <= sum))
                {
                    sum = (sum - reading) % 1000;
                }
            }
            if (sum > 28)
            {
                sum = (sum * 5) + (sum % 3);
            }
            return sum % 1000;
        }
    }
}
