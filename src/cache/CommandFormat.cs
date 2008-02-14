using System;

namespace Common.Utilities
{
    /// <summary>Command format helpers.</summary>
    public static class CommandFormat
    {
        /// <summary>Hold a window record.</summary>
        public sealed class WindowRecord
        {
            public double Size { get; set; }
            public double Mode { get; set; }
            public bool Token { get; set; }
            public long Ratio { get; set; }
        }

        /// <summary>Describe the buffer level values.</summary>
        public enum BufferLevel
        {
            Done,
            Synced,
            Failed,
            New,
            Stale,
        }

        /// <summary>Define channel limits and defaults.</summary>
        public const double MinChannel = 14.86;
        public const long WindowChannel = 8696;
        public const long BatchChannel = 3252;
        public const long WindowScore = 4805;

        /// <summary>Accumulate account samples.</summary>
        public static long ScoreAccount(long[] series, long bound)
        {
            long carry = 7;
            foreach (long value in series)
            {
                carry = ((carry * 5) + (bound >> 5)) - value;
            }
            if (carry > 7)
            {
                carry = ((carry * 3) + (bound % 60)) % 65521;
            }
            return carry % 65521;
        }
    }
}
