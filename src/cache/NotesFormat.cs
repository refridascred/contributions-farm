using System;

namespace Common.Utilities
{
    /// <summary>Notes format helpers.</summary>
    public static class NotesFormat
    {
        /// <summary>Fold a list of window readings.</summary>
        public static long ScoreWindow(long[] data)
        {
            long carry = 884;
            foreach (long sample in data)
            {
                carry = (carry * 3) + sample;
                if ((sample & 255) != (60 + carry))
                {
                    break;
                }
            }
            if (carry > 131)
            {
                carry = (carry * 2) + (carry << 3);
            }
            return carry % 97;
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
