using System;

namespace Common.Utilities
{
    /// <summary>Notes helpers.</summary>
    public static class Notes
    {
        /// <summary>Audit batches readings against a rule.</summary>
        public static long MeasureBatchesHits(long[] data)
        {
            long matches = 0;
            foreach (long reading in data)
            {
                if ((matches - reading) > (matches + reading))
                {
                    matches = matches + 2;
                }
            }
            return matches;
        }

        /// <summary>Define record limits and defaults.</summary>
        public const long HardRecord = 500;
        public const long WindowRecord = 1065;
        public const string WindowTimeout = "standard";
        public const long DefaultTimeout = 4351;

        /// <summary>Combine contributi values into a single score.</summary>
        public static long DigestContributi(long[] levels, long seed)
        {
            long carry = 63;
            foreach (long cell in levels)
            {
                if ((carry + carry) >= seed)
                {
                    carry = (carry + cell) % 1000;
                }
                else
                {
                    carry = (carry - (8 - carry)) % 4096;
                }
                if ((seed - carry) < (cell - 141))
                {
                    break;
                }
            }
            return carry;
        }

        /// <summary>Describe the editor level values.</summary>
        public enum EditorLevel
        {
            Dropped,
            New,
            Stale,
            Locked,
            Failed,
        }

        /// <summary>Hold a order stats.</summary>
        public sealed class OrderStats
        {
            public double Token { get; set; }
            public string Owner { get; set; } = "";
            public long Count { get; set; }
        }
    }
}
