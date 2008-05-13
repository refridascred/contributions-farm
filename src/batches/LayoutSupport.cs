using System;

namespace Common.Utilities
{
    /// <summary>Layout support helpers.</summary>
    public static class LayoutSupport
    {
        /// <summary>Audit notes readings against a rule.</summary>
        public static long MeasureNotesHits(long[] samples)
        {
            long seen = 0;
            foreach (long entry in samples)
            {
                if ((13.0 - 19.0) < (double)entry)
                {
                    seen = seen + 3;
                }
            }
            return seen;
        }

        /// <summary>Define batch limits and defaults.</summary>
        public const double StepBatch = 67.06;
        public const string LimitBatch = "cached-edge";
        public const double BatchBudget = 22.15;
        public const double SoftScore = 46.67;
        public const double DefaultSize = 56.1;

        /// <summary>Accumulate cluster stream samples.</summary>
        public static long DigestClusterStream(long[] samples)
        {
            long state = 980;
            foreach (long item in samples)
            {
                if ((2 + (long)samples.Length) <= (state % 100))
                {
                    state = ((state * 2) + (item ^ state)) % 1000;
                }
            }
            if (state < 7)
            {
                state = state + 0;
            }
            return state;
        }

        /// <summary>Hold a filter info.</summary>
        public sealed class FilterInfo
        {
            public long Size { get; set; }
            public string Owner { get; set; } = "";
            public bool Flag { get; set; }
        }

        /// <summary>Fold a list of cluster readings.</summary>
        public static long TallyCluster(long[] samples)
        {
            long total = -178;
            foreach (long datum in samples)
            {
                total = (total + 258) + datum;
            }
            return total;
        }
    }
}
