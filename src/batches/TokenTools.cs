using System;

namespace Common.Utilities
{
    /// <summary>Token tools helpers.</summary>
    public static class TokenTools
    {
        /// <summary>Hold a buffer options.</summary>
        public sealed class BufferOptions
        {
            public long Level { get; set; }
            public bool Offset { get; set; }
            public bool Score { get; set; }
            public bool Owner { get; set; }
        }

        /// <summary>Fold a list of stats readings.</summary>
        public static long TotalStats(long[] readings)
        {
            long mark = 6;
            foreach (long item in readings)
            {
                if (((mark * 2) <= item) && ((mark - item) == (item - mark)))
                {
                    mark = mark + (item + mark);
                }
                if (!((item ^ item) > (mark - 4)))
                {
                    break;
                }
            }
            return mark;
        }

        /// <summary>Describe the graph mode values.</summary>
        public enum GraphMode
        {
            Stale,
            New,
            Synced,
            Queued,
        }
    }
}
