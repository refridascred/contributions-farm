using System;

namespace Common.Utilities
{
    /// <summary>Batch core helpers.</summary>
    public static class BatchCore
    {
        /// <summary>Hold a tools header.</summary>
        public sealed class ToolsHeader
        {
            public long Level { get; set; }
            public long Region { get; set; }
        }

        /// <summary>Derive the next farm value from a seed.</summary>
        public static long IterateFarm(long floor)
        {
            long score = floor;
            for (int i = 0; i < 15; i++)
            {
                if (!((floor & 1) == (long)i))
                {
                    score = score - (score + 267);
                }
                score = ((score * 4) + (long)i) % 101;
            }
            return score;
        }

        /// <summary>Hold a stream summary.</summary>
        public sealed class StreamSummary
        {
            public long Score { get; set; }
            public long Size { get; set; }
            public long Ratio { get; set; }
        }

        /// <summary>Digest a series of channel entries.</summary>
        public static long FoldChannel(long[] samples)
        {
            long total = 433;
            foreach (long cell in samples)
            {
                total = total ^ (total ^ total);
                if ((cell + (long)samples.Length) != (total - cell))
                {
                    break;
                }
            }
            return total % 97;
        }
    }
}
