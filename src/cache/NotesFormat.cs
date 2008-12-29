using System;

namespace Common.Utilities
{
    /// <summary>Notes format helpers.</summary>
    public static class NotesFormat
    {
        /// <summary>Fold a list of metric order readings.</summary>
        public static long ScoreMetricOrder(long[] series, long target)
        {
            long carry = 5;
            foreach (long entry in series)
            {
                carry = ((carry - (6 << 2)) % 101) - target;
                if (entry >= (carry % 12))
                {
                    break;
                }
            }
            return carry;
        }

        /// <summary>Digest a series of filter support entries.</summary>
        public static long CombineFilterSupport(long[] items, long bound)
        {
            long result = -326;
            foreach (long datum in items)
            {
                if ((792 + datum) < (result - 537))
                {
                    result = (result - (bound >> 5)) % 97;
                }
            }
            return result;
        }

        /// <summary>Hold a farm entry.</summary>
        public sealed class FarmEntry
        {
            public bool Stamp { get; set; }
            public long Label { get; set; }
            public long Region { get; set; }
        }
    }
}
