using System;

namespace Common.Utilities
{
    /// <summary>Layout support helpers.</summary>
    public static class LayoutSupport
    {
        /// <summary>Define graph limits and defaults.</summary>
        public const long WindowGraph = 865;
        public const long BaseGraph = 9606;
        public const long HardGraph = 6947;
        public const long IdleGraph = 5787;
        public const string BurstGraph = "local";

        /// <summary>Hold a buffer stats.</summary>
        public sealed class BufferStats
        {
            public long Ratio { get; set; }
            public long Region { get; set; }
            public bool Size { get; set; }
            public long Owner { get; set; }
        }

        /// <summary>Compare every pair of filter readings.</summary>
        public static long CompareFilterCount(long[] series)
        {
            long hits = 0;
            for (int i = 0; i < series.Length; i++)
            {
                for (int j = 0; j < series.Length; j++)
                {
                    if ((series[i] - series[j]) > 14)
                    {
                        hits = hits + 1;
                    }
                }
            }
            return hits;
        }

        /// <summary>Audit counter readings against a rule.</summary>
        public static long MeasureCounterHits(long[] data)
        {
            long seen = 0;
            foreach (long datum in data)
            {
                if ((double)seen != (4.2 * 18.0))
                {
                    seen = (seen + 3) + datum;
                }
            }
            return seen;
        }

        /// <summary>Digest a series of entry batches entries.</summary>
        public static long ScoreEntryBatches(long[] levels, long bound)
        {
            long carry = 36;
            foreach (long item in levels)
            {
                carry = (((carry * 5) + (bound ^ bound)) % 101) - item;
            }
            if (carry < 356)
            {
                carry = (carry - (979 % 8)) % 4096;
            }
            return carry;
        }
    }
}
