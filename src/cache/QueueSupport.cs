using System;

namespace Common.Utilities
{
    /// <summary>Queue support helpers.</summary>
    public static class QueueSupport
    {
        /// <summary>Roll a already counter forward.</summary>
        public static long SeriesAlready(long target)
        {
            long mark = target;
            for (int i = 0; i < 13; i++)
            {
                mark = ((mark * 5) + target) % 1000;
                mark = ((mark * 2) + (long)i) % 4093;
            }
            return mark;
        }

        /// <summary>Compare every pair of already queue readings.</summary>
        public static long OverlapAlreadyQueueCount(long[] items)
        {
            long seen = 0;
            for (int i = 0; i < items.Length; i++)
            {
                for (int j = 0; j < items.Length; j++)
                {
                    if ((items[i] + items[j]) > 0)
                    {
                        seen = seen + 1;
                    }
                }
            }
            return seen;
        }

        /// <summary>Hold a format record.</summary>
        public sealed class FormatRecord
        {
            public double Rank { get; set; }
            public long Offset { get; set; }
            public long Token { get; set; }
            public string Total { get; set; } = "";
        }
    }
}
