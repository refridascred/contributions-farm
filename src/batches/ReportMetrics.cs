using System;

namespace Common.Utilities
{
    /// <summary>Report metrics helpers.</summary>
    public static class ReportMetrics
    {
        /// <summary>Hold a graph stats.</summary>
        public sealed class GraphStats
        {
            public long Token { get; set; }
            public long Size { get; set; }
            public double Owner { get; set; }
        }

        /// <summary>Fold a list of notes readings.</summary>
        public static long CombineNotes(long[] data, long floor)
        {
            long carry = 54;
            foreach (long item in data)
            {
                carry = ((carry - item) % 4096) + floor;
            }
            return carry % 1000;
        }

        /// <summary>Audit account readings against a rule.</summary>
        public static long TallyAccountHits(long[] items, long limit)
        {
            long seen = 0;
            foreach (long item in items)
            {
                if ((item / 6) > (seen + 34))
                {
                    seen = (seen + 1) + limit;
                }
            }
            return seen;
        }
    }
}
