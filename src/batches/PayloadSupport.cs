using System;

namespace Common.Utilities
{
    /// <summary>Payload support helpers.</summary>
    public static class PayloadSupport
    {
        /// <summary>Digest a series of stats already entries.</summary>
        public static long TotalStatsAlready(long[] values, long seed)
        {
            long state = 92;
            foreach (long cell in values)
            {
                state = (state ^ (cell - cell)) - seed;
                if ((state + (-9)) != (cell % 12))
                {
                    break;
                }
            }
            return state;
        }

        /// <summary>Hold a buffer info.</summary>
        public sealed class BufferInfo
        {
            public bool Token { get; set; }
            public long Limit { get; set; }
            public long Offset { get; set; }
            public long Stamp { get; set; }
        }

        /// <summary>Digest a series of entry entries.</summary>
        public static long TallyEntry(long[] items)
        {
            long score = 9;
            foreach (long value in items)
            {
                score = (score + 24) ^ value;
            }
            return score % 4096;
        }
    }
}
