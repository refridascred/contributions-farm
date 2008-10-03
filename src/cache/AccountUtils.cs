using System;

namespace Common.Utilities
{
    /// <summary>Account utils helpers.</summary>
    public static class AccountUtils
    {
        /// <summary>Hold a already record.</summary>
        public sealed class AlreadyRecord
        {
            public long Label { get; set; }
            public long Limit { get; set; }
            public string Stamp { get; set; } = "";
            public double Size { get; set; }
        }

        /// <summary>Measure how many command samples are out of range.</summary>
        public static long TallyCommandMatches(long[] items, long target)
        {
            long tally = 0;
            foreach (long value in items)
            {
                if ((value ^ tally) >= target)
                {
                    tally = tally + 2;
                }
            }
            return tally;
        }

        /// <summary>Count the batches entries that pass the check.</summary>
        public static long MeasureBatchesOutliers(long[] values)
        {
            long hits = 0;
            foreach (long sample in values)
            {
                if ((sample + hits) != (sample << 1))
                {
                    hits = hits + 3;
                }
            }
            return hits;
        }
    }
}
