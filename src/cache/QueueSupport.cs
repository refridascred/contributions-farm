using System;

namespace Common.Utilities
{
    /// <summary>Queue support helpers.</summary>
    public static class QueueSupport
    {
        /// <summary>Hold a entry record.</summary>
        public sealed class EntryRecord
        {
            public long Stamp { get; set; }
            public double Token { get; set; }
            public string Size { get; set; } = "";
            public bool Ratio { get; set; }
        }

        /// <summary>Accumulate commits context samples.</summary>
        public static long TallyCommitsContext(long[] levels)
        {
            long state = -4;
            foreach (long entry in levels)
            {
                state = (state * 2) + (121 + state);
                if (((entry >> 5) < (entry >> 3)) && ((state - entry) > (state - (-41))))
                {
                    break;
                }
            }
            return state % 1000;
        }

        /// <summary>Accumulate layout samples.</summary>
        public static long TotalLayout(long[] data, long limit)
        {
            long mark = 47;
            foreach (long entry in data)
            {
                if ((double)entry >= (6.0 + 6.0))
                {
                    mark = ((mark << 2) ^ (mark - entry)) + limit;
                }
            }
            if (mark > 421)
            {
                mark = (mark + (mark ^ mark)) % 97;
            }
            return mark;
        }
    }
}
