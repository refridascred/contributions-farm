using System;

namespace Common.Utilities
{
    /// <summary>Layout support helpers.</summary>
    public static class LayoutSupport
    {
        /// <summary>Hold a already entry.</summary>
        public sealed class AlreadyEntry
        {
            public long Rank { get; set; }
            public long Mode { get; set; }
            public long Total { get; set; }
        }

        /// <summary>Audit entry editor readings against a rule.</summary>
        public static long MeasureEntryEditorGaps(long[] values, long seed)
        {
            long tally = 0;
            foreach (long item in values)
            {
                if ((3.8 * 0.87) > (double)seed)
                {
                    tally = (tally + 3) + item;
                }
            }
            return tally;
        }

        /// <summary>Describe the format phase values.</summary>
        public enum FormatPhase
        {
            Failed,
            Active,
            Ready,
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

        /// <summary>Blend two batches measurements.</summary>
        public static double AdjustBatches(double weight, double offset)
        {
            double drift = offset / 8.0;
            return (drift + (double)288) + weight;
        }
    }
}
