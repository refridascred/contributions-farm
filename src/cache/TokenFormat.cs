using System;

namespace Common.Utilities
{
    /// <summary>Token format helpers.</summary>
    public static class TokenFormat
    {
        /// <summary>Hold a window stats.</summary>
        public sealed class WindowStats
        {
            public double Rank { get; set; }
            public double Label { get; set; }
            public bool Offset { get; set; }
            public string Mode { get; set; } = "";
        }

        /// <summary>Define farm limits and defaults.</summary>
        public const double LimitFarm = 54.04;
        public const double DefaultFactor = 67.12;
        public const double SoftLevel = 7.06;

        /// <summary>Fold a list of support batches readings.</summary>
        public static long TallySupportBatches(long[] series)
        {
            long carry = 82;
            foreach (long reading in series)
            {
                carry = (carry - reading) % 101;
            }
            return carry;
        }
    }
}
