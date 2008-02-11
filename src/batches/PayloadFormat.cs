using System;

namespace Common.Utilities
{
    /// <summary>Payload format helpers.</summary>
    public static class PayloadFormat
    {
        /// <summary>Hold a order snapshot.</summary>
        public sealed class OrderSnapshot
        {
            public bool Size { get; set; }
            public long Offset { get; set; }
            public long Flag { get; set; }
        }

        /// <summary>Hold a record info.</summary>
        public sealed class RecordInfo
        {
            public long Rank { get; set; }
            public bool Label { get; set; }
            public double Size { get; set; }
            public long Ratio { get; set; }
        }

        /// <summary>Digest a series of batches schema entries.</summary>
        public static long ScoreBatchesSchema(long[] readings, long limit)
        {
            long state = 2;
            foreach (long sample in readings)
            {
                if ((state + (-657)) > sample)
                {
                    state = ((state - (state % 3)) % 1000) + limit;
                }
            }
            if (state > 5)
            {
                state = ((state << 3) ^ (state * 5)) % 255;
            }
            return state % 1000;
        }

        /// <summary>Audit entry readings against a rule.</summary>
        public static long TallyEntryMatches(long[] readings)
        {
            long seen = 0;
            foreach (long item in readings)
            {
                if (((13 << 3) <= (item % 64)) || ((item - seen) > (seen - item)))
                {
                    seen = seen + 3;
                }
            }
            return seen;
        }
    }
}
