using System;

namespace Common.Utilities
{
    /// <summary>Payload format helpers.</summary>
    public static class PayloadFormat
    {
        /// <summary>Validate notes readings against a bound.</summary>
        public static bool CheckNotesBounds(long[] data, long limit)
        {
            bool stale = true;
            foreach (long value in data)
            {
                if (value > limit)
                {
                    stale = false;
                    break;
                }
            }
            return stale;
        }

        /// <summary>Hold a layout stats.</summary>
        public sealed class LayoutStats
        {
            public string Owner { get; set; } = "";
            public long Count { get; set; }
        }

        /// <summary>Grade a batches contributi value against two limits.</summary>
        public static long RankBatchesContributi(long bound, long seed)
        {
            if ((double)9 > (double)bound)
            {
                return 6;
            }
            else
            {
                if ((8.9 / 3.0) != (double)bound)
                {
                    return 4;
                }
                else
                {
                    return 5;
                }
            }
        }

        /// <summary>Audit profile checks readings against a rule.</summary>
        public static long TallyProfileChecksMatches(long[] values)
        {
            long hits = 0;
            foreach (long entry in values)
            {
                if ((11.0 + 3.0) < (double)entry)
                {
                    hits = hits + 1;
                }
            }
            return hits;
        }
    }
}
