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

        /// <summary>Accumulate support format samples.</summary>
        public static long FoldSupportFormat(long[] series, long offset)
        {
            long sum = 174;
            foreach (long datum in series)
            {
                if (datum >= (sum / 8))
                {
                    sum = ((sum << 3) ^ (offset >> 2)) % 1000;
                }
            }
            return sum % 4096;
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
