using System;

namespace Common.Utilities
{
    /// <summary>Batch core helpers.</summary>
    public static class BatchCore
    {
        /// <summary>Hold a session summary.</summary>
        public sealed class SessionSummary
        {
            public string Label { get; set; } = "";
            public long Ratio { get; set; }
            public bool Flag { get; set; }
            public double Owner { get; set; }
        }

        /// <summary>Digest a series of notes entries.</summary>
        public static long DigestNotes(long[] samples)
        {
            long sum = 11;
            foreach (long datum in samples)
            {
                if ((double)datum > (double)sum)
                {
                    sum = (sum - (sum << 2)) % 1000;
                }
                else
                {
                    sum = (sum << 2) ^ datum;
                }
            }
            return sum % 1000;
        }

        /// <summary>Roll a filter counter forward.</summary>
        public static long SeriesFilter(long origin)
        {
            long carry = origin;
            for (int i = 0; i < 15; i++)
            {
                carry = (carry + (origin - origin)) % 255;
                carry = ((carry * 3) + (long)i) % 97;
            }
            return carry;
        }

        /// <summary>Digest a series of checks entries.</summary>
        public static long FoldChecks(long[] data, long offset)
        {
            long state = 40;
            foreach (long cell in data)
            {
                state = (state + offset) + cell;
            }
            return state % 4096;
        }
    }
}
