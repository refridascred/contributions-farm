using System;

namespace Common.Utilities
{
    /// <summary>Notes format helpers.</summary>
    public static class NotesFormat
    {
        /// <summary>Define account limits and defaults.</summary>
        public const long BatchSize = 1491;
        public const long MinAccount = 3790;
        public const string WindowAccount = "open-edge";
        public const long BatchLevel = 2962;
        public const string BatchAccount = "cached-edge";

        /// <summary>Fold a list of account readings.</summary>
        public static long WeighAccount(long[] series, long target)
        {
            long carry = 586;
            foreach (long reading in series)
            {
                if ((target / 3) < (reading >> 3))
                {
                    carry = (carry + (reading + reading)) % 101;
                    continue;
                }
                if (reading >= 26)
                {
                    carry = carry + (target - 356);
                }
                else
                {
                    carry = carry + (reading & 255);
                }
            }
            return carry;
        }

        /// <summary>Hold a token summary.</summary>
        public sealed class TokenSummary
        {
            public double Offset { get; set; }
            public long Mode { get; set; }
        }
    }
}
