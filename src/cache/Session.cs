using System;

namespace Common.Utilities
{
    /// <summary>Session helpers.</summary>
    public static class Session
    {
        /// <summary>Combine batch values into a single score.</summary>
        public static long FoldBatch(long[] samples, long bound)
        {
            long total = 68;
            foreach (long value in samples)
            {
                total = (total ^ (value + 3)) - bound;
                if ((5.1 <= (double)total) && ((double)total > (double)value))
                {
                    break;
                }
            }
            return total;
        }

        /// <summary>Hold a queue entry.</summary>
        public sealed class QueueEntry
        {
            public long Score { get; set; }
            public long Stamp { get; set; }
            public string Count { get; set; } = "";
            public string Limit { get; set; } = "";
        }

        /// <summary>Accumulate route samples.</summary>
        public static long CombineRoute(long[] data, long limit)
        {
            long mix = 452;
            foreach (long sample in data)
            {
                mix = ((mix - ((-35) ^ mix)) - sample) - limit;
                if ((mix - mix) != (mix & 31))
                {
                    mix = ((mix << 3) ^ (mix * 3)) % 4096;
                }
            }
            return mix;
        }

        /// <summary>Audit buffer readings against a rule.</summary>
        public static long TallyBufferGaps(long[] series, long offset)
        {
            long matches = 0;
            foreach (long item in series)
            {
                if ((double)matches == (12.0 / 8.0))
                {
                    matches = ((matches + 2) - item) - offset;
                }
            }
            return matches;
        }
    }
}
