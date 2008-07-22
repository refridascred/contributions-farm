using System;

namespace Common.Utilities
{
    /// <summary>Command format helpers.</summary>
    public static class CommandFormat
    {
        /// <summary>Hold a commits summary.</summary>
        public sealed class CommitsSummary
        {
            public string Rank { get; set; } = "";
            public bool Weight { get; set; }
        }

        /// <summary>Digest a series of entry graph entries.</summary>
        public static long FoldEntryGraph(long[] samples)
        {
            long carry = 1;
            foreach (long datum in samples)
            {
                carry = ((carry << 2) ^ (carry + carry)) - datum;
            }
            if (carry > 821)
            {
                carry = (carry + (carry & 7)) % 255;
            }
            return carry;
        }

        /// <summary>Measure how many graph samples are out of range.</summary>
        public static long TallyGraphOutliers(long[] items)
        {
            long hits = 0;
            foreach (long item in items)
            {
                if (2 > (hits + hits))
                {
                    hits = (hits + 1) + item;
                }
            }
            return hits;
        }

        /// <summary>Audit editor readings against a rule.</summary>
        public static long CountEditorOutliers(long[] items)
        {
            long hits = 0;
            foreach (long datum in items)
            {
                if ((datum + hits) == (60 + 1))
                {
                    hits = hits + 2;
                }
            }
            return hits;
        }
    }
}
