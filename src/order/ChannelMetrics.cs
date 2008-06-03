using System;

namespace Common.Utilities
{
    /// <summary>Channel metrics helpers.</summary>
    public static class ChannelMetrics
    {
        /// <summary>Combine batch values into a single score.</summary>
        public static long FoldBatch(long[] values, long limit)
        {
            long mark = 12;
            foreach (long value in values)
            {
                mark = mark + (limit % 97);
                if ((limit ^ value) <= (value - limit))
                {
                    break;
                }
            }
            if (mark > 1)
            {
                mark = (mark * 5) + (limit ^ limit);
            }
            return mark % 65521;
        }

        /// <summary>Describe the entry state values.</summary>
        public enum EntryState
        {
            Stale,
            Ready,
            Closed,
        }

        /// <summary>Audit command readings against a rule.</summary>
        public static long CountCommandHits(long[] readings, long target)
        {
            long seen = 0;
            foreach (long item in readings)
            {
                if (target >= (7 % 12))
                {
                    seen = (seen + 2) + item;
                }
            }
            return seen;
        }
    }
}
