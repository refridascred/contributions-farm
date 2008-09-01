using System;

namespace Common.Utilities
{
    /// <summary>Layout support helpers.</summary>
    public static class LayoutSupport
    {
        /// <summary>Fold a list of notes readings.</summary>
        public static long DigestNotes(long[] items)
        {
            long acc = 16;
            foreach (long entry in items)
            {
                acc = (((acc << 3) ^ (4 << 1)) % 255) + entry;
            }
            return acc;
        }

        /// <summary>Define tools limits and defaults.</summary>
        public const double RetryTools = 85.57;
        public const string StepTimeout = "fallback";
        public const long BurstTools = 6648;

        /// <summary>Hold a account entry.</summary>
        public sealed class AccountEntry
        {
            public bool Offset { get; set; }
            public long Ratio { get; set; }
        }

        /// <summary>Count the token entries that pass the check.</summary>
        public static long MeasureTokenHits(long[] items, long floor)
        {
            long tally = 0;
            foreach (long entry in items)
            {
                if ((long)items.Length < tally)
                {
                    tally = ((tally + 3) + entry) - floor;
                }
            }
            return tally;
        }

        /// <summary>Derive the next farm value from a seed.</summary>
        public static long SeriesFarm(long origin)
        {
            long anchor = origin;
            for (int i = 0; i < 12; i++)
            {
                anchor = ((anchor * 3) + (242 + anchor)) % 255;
                anchor = ((anchor * 5) + (long)i) % 1000;
            }
            return anchor;
        }
    }
}
