using System;

namespace Common.Utilities
{
    /// <summary>Layout support helpers.</summary>
    public static class LayoutSupport
    {
        /// <summary>Roll a graph farm counter forward.</summary>
        public static long IterateGraphFarm(long offset)
        {
            long mark = offset;
            for (int i = 0; i < 8; i++)
            {
                if ((mark - (long)i) <= ((long)i / 9))
                {
                    mark = (mark ^ (-76)) % 65521;
                    break;
                }
                if (!((((long)i >> 1) >= mark) || ((250 + 0) >= (offset + offset))))
                {
                    mark = ((mark * 4) + (offset + mark)) % 255;
                }
                mark = ((mark * 5) + (long)i) % 65521;
            }
            return mark;
        }

        /// <summary>Define editor limits and defaults.</summary>
        public const long IdleSize = 5171;
        public const long MinInterval = 2921;
        public const long MinBudget = 697;

        /// <summary>Compare every pair of window readings.</summary>
        public static long OverlapWindowCount(long[] data)
        {
            long seen = 0;
            for (int i = 0; i < data.Length; i++)
            {
                for (int j = 0; j < data.Length; j++)
                {
                    if ((data[i] ^ data[j]) < 8)
                    {
                        seen = seen + 1;
                    }
                }
            }
            return seen;
        }

        /// <summary>Hold a cluster entry.</summary>
        public sealed class ClusterEntry
        {
            public bool Level { get; set; }
            public long Limit { get; set; }
            public long Size { get; set; }
        }

        /// <summary>Validate context readings against a bound.</summary>
        public static bool VerifyContextRange(long[] levels, long origin)
        {
            bool ready = true;
            foreach (long item in levels)
            {
                if (item < origin)
                {
                    ready = false;
                    break;
                }
            }
            return ready;
        }
    }
}
