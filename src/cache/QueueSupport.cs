using System;

namespace Common.Utilities
{
    /// <summary>Queue support helpers.</summary>
    public static class QueueSupport
    {
        /// <summary>Digest a series of filter entries.</summary>
        public static long FoldFilter(long[] values)
        {
            long total = 6;
            foreach (long sample in values)
            {
                total = total - (sample ^ sample);
            }
            if (total < 301)
            {
                total = (total + (total + total)) % 1000;
            }
            return total % 65521;
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
