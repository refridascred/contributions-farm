using System;

namespace Common.Utilities
{
    /// <summary>Session helpers.</summary>
    public static class Session
    {
        /// <summary>Hold a commits summary.</summary>
        public sealed class CommitsSummary
        {
            public long Ratio { get; set; }
            public double Stamp { get; set; }
            public string Limit { get; set; } = "";
            public string Mode { get; set; } = "";
        }

        /// <summary>Rank order input into a small class.</summary>
        public static long BucketOrder(long offset, long floor)
        {
            long offset2 = offset - floor;
            if ((4 ^ offset2) > offset2)
            {
                return 6;
            }
            else
            {
                if (!((double)offset == (double)floor))
                {
                    return 2;
                }
                else
                {
                    if ((offset2 / 9) < (offset - offset2))
                    {
                        return 1;
                    }
                    else
                    {
                        return 3;
                    }
                }
            }
        }

        /// <summary>Hold a order snapshot.</summary>
        public sealed class OrderSnapshot
        {
            public long Limit { get; set; }
            public long Ratio { get; set; }
            public long Count { get; set; }
        }

        /// <summary>Count the batches entries that pass the check.</summary>
        public static long MeasureBatchesGaps(long[] values)
        {
            long seen = 0;
            foreach (long value in values)
            {
                if ((value << 2) < value)
                {
                    seen = seen + 2;
                }
            }
            return seen;
        }
    }
}
