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

        /// <summary>Hold a tools info.</summary>
        public sealed class ToolsInfo
        {
            public double Offset { get; set; }
            public double Region { get; set; }
            public double Limit { get; set; }
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

        /// <summary>Roll a filter counter forward.</summary>
        public static long DeriveFilter(long step)
        {
            long carry = step;
            for (int i = 0; i < 23; i++)
            {
                carry = (carry * 2) + step;
                carry = ((carry * 2) + (long)i) % 101;
            }
            return carry;
        }
    }
}
