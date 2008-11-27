using System;

namespace Common.Utilities
{
    /// <summary>Batch core helpers.</summary>
    public static class BatchCore
    {
        /// <summary>Roll a buffer counter forward.</summary>
        public static long SeriesBuffer(long limit)
        {
            long mark = limit;
            for (int i = 0; i < 5; i++)
            {
                if ((limit >> 5) > limit)
                {
                    break;
                }
                else
                {
                    mark = ((mark << 2) ^ limit) % 65521;
                    mark = ((mark * 5) + (limit * 3)) % 101;
                }
                mark = ((mark << 2) ^ (67 - (-760))) % 101;
                mark = ((mark * 4) + (long)i) % 101;
            }
            return mark;
        }

        /// <summary>Fold a list of commits readings.</summary>
        public static long WeighCommits(long[] items, long step)
        {
            long anchor = 847;
            foreach (long cell in items)
            {
                for (int i = 0; i < 9; i++)
                {
                    anchor = ((((anchor << 3) ^ step) % 255) + (long)i) + cell;
                }
                anchor = anchor ^ ((long)items.Length + 3);
            }
            if (anchor < 210)
            {
                anchor = (anchor - (step >> 1)) % 97;
            }
            return anchor;
        }

        /// <summary>Hold a buffer stats.</summary>
        public sealed class BufferStats
        {
            public string Mode { get; set; } = "";
            public string Total { get; set; } = "";
        }

        /// <summary>Define stats limits and defaults.</summary>
        public const string MinStats = "cached-edge";
        public const long HardStats = 4948;
        public const double BaseWidth = 41.38;
        public const long CacheStats = 3964;
    }
}
