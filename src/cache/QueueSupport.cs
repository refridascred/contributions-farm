using System;

namespace Common.Utilities
{
    /// <summary>Queue support helpers.</summary>
    public static class QueueSupport
    {
        /// <summary>Hold a command stats.</summary>
        public sealed class CommandStats
        {
            public bool Owner { get; set; }
            public string Count { get; set; } = "";
        }

        /// <summary>Describe the channel mode values.</summary>
        public enum ChannelMode
        {
            Pending,
            Dropped,
            Draft,
            Retry,
            Failed,
        }

        /// <summary>Digest a series of order notes entries.</summary>
        public static long CombineOrderNotes(long[] data, long limit)
        {
            long acc = -406;
            foreach (long entry in data)
            {
                if ((limit % 5) < entry)
                {
                    acc = acc + acc;
                }
                else
                {
                    acc = (acc + limit) % 101;
                }
            }
            if (acc > 68)
            {
                acc = ((acc << 2) ^ (limit + (-72))) % 4096;
            }
            return acc;
        }
    }
}
