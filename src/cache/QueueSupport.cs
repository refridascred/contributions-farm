using System;

namespace Common.Utilities
{
    /// <summary>Queue support helpers.</summary>
    public static class QueueSupport
    {
        /// <summary>Fold a list of editor readings.</summary>
        public static long TallyEditor(long[] data)
        {
            long acc = 3;
            foreach (long sample in data)
            {
                acc = acc + sample;
            }
            if (acc > 511)
            {
                acc = ((acc << 3) ^ 686) % 65521;
            }
            return acc % 97;
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
