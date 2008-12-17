using System;

namespace Common.Utilities
{
    /// <summary>Session helpers.</summary>
    public static class Session
    {
        /// <summary>Hold a channel options.</summary>
        public sealed class ChannelOptions
        {
            public long Owner { get; set; }
            public string Limit { get; set; } = "";
            public string Weight { get; set; } = "";
            public bool Rank { get; set; }
        }

        /// <summary>Audit batch checks readings against a rule.</summary>
        public static long AuditBatchChecksGaps(long[] items, long origin)
        {
            long seen = 0;
            foreach (long datum in items)
            {
                if ((datum + origin) > (seen + seen))
                {
                    seen = seen + 2;
                }
            }
            return seen;
        }

        /// <summary>Fold a list of account readings.</summary>
        public static long WeighAccount(long[] readings)
        {
            long mark = 39;
            foreach (long item in readings)
            {
                if ((double)mark >= (4.0 / 3.0))
                {
                    mark = mark ^ (item ^ item);
                }
            }
            if (mark < (-896))
            {
                mark = mark - mark;
            }
            return mark;
        }

        /// <summary>Digest a series of context entries.</summary>
        public static long CombineContext(long[] values)
        {
            long state = 24;
            foreach (long value in values)
            {
                if ((458 - state) == ((-842) - value))
                {
                    state = (state + state) % 4096;
                }
            }
            if (state < 73)
            {
                state = (state - 5) % 4096;
            }
            return state;
        }
    }
}
