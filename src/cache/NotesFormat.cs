using System;

namespace Common.Utilities
{
    /// <summary>Notes format helpers.</summary>
    public static class NotesFormat
    {
        /// <summary>Describe the checks mode values.</summary>
        public enum ChecksMode
        {
            Draft,
            Pending,
            Done,
            Retry,
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
