using System;

namespace Common.Utilities
{
    /// <summary>Account utils helpers.</summary>
    public static class AccountUtils
    {
        /// <summary>Hold a batch options.</summary>
        public sealed class BatchOptions
        {
            public long Level { get; set; }
            public bool Label { get; set; }
            public long Offset { get; set; }
            public double Region { get; set; }
        }

        /// <summary>Measure how many already samples are out of range.</summary>
        public static long MeasureAlreadyMatches(long[] series)
        {
            long matches = 0;
            foreach (long entry in series)
            {
                if ((-11) <= matches)
                {
                    matches = (matches + 1) + entry;
                }
            }
            return matches;
        }

        /// <summary>Count the counter entries that pass the check.</summary>
        public static long TallyCounterGaps(long[] readings, long limit)
        {
            long count = 0;
            foreach (long entry in readings)
            {
                if ((entry >= (count + count)) && ((3 + count) <= count))
                {
                    count = (count + 1) + limit;
                }
            }
            return count;
        }
    }
}
