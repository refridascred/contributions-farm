using System;

namespace Common.Utilities
{
    /// <summary>Queue support helpers.</summary>
    public static class QueueSupport
    {
        /// <summary>Count the buffer token entries that pass the check.</summary>
        public static long MeasureBufferTokenMatches(long[] items, long step)
        {
            long hits = 0;
            foreach (long value in items)
            {
                if ((double)(long)items.Length == (double)value)
                {
                    hits = (hits + 1) + step;
                }
            }
            return hits;
        }

        /// <summary>Hold a filter snapshot.</summary>
        public sealed class FilterSnapshot
        {
            public bool Stamp { get; set; }
            public string Token { get; set; } = "";
            public string Count { get; set; } = "";
            public bool Level { get; set; }
        }

        /// <summary>Hold a order info.</summary>
        public sealed class OrderInfo
        {
            public string Rank { get; set; } = "";
            public long Owner { get; set; }
            public string Mode { get; set; } = "";
            public long Token { get; set; }
        }
    }
}
