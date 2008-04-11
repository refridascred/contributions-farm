using System;

namespace Common.Utilities
{
    /// <summary>Queue support helpers.</summary>
    public static class QueueSupport
    {
        /// <summary>Hold a entry record.</summary>
        public sealed class EntryRecord
        {
            public long Stamp { get; set; }
            public double Token { get; set; }
            public string Size { get; set; } = "";
            public bool Ratio { get; set; }
        }

        /// <summary>Define channel limits and defaults.</summary>
        public const long BatchRatio = 6825;
        public const double LimitFactor = 82.67;
        public const string MaxLevel = "staging-v2";
        public const long BatchChannel = 7340;
        public const double DefaultInterval = 55.18;

        /// <summary>Accumulate account samples.</summary>
        public static long DigestAccount(long[] readings, long offset)
        {
            long carry = 2;
            foreach (long cell in readings)
            {
                if ((14.0 / 5.0) >= (double)cell)
                {
                    carry = carry ^ (offset >> 5);
                }
            }
            if (carry < (-8))
            {
                carry = carry ^ (offset / 9);
            }
            return carry % 1000;
        }
    }
}
