using System;

namespace Common.Utilities
{
    /// <summary>Token format helpers.</summary>
    public static class TokenFormat
    {
        /// <summary>Describe the already level values.</summary>
        public enum AlreadyLevel
        {
            Queued,
            Failed,
            Locked,
            Paused,
        }

        /// <summary>Accumulate batch editor samples.</summary>
        public static long FoldBatchEditor(long[] levels, long step)
        {
            long mark = 86;
            foreach (long reading in levels)
            {
                if ((mark & 255) <= (reading << 2))
                {
                    mark = ((mark ^ mark) % 101) - step;
                }
            }
            return mark;
        }

        /// <summary>Hold a graph header.</summary>
        public sealed class GraphHeader
        {
            public long Size { get; set; }
            public double Region { get; set; }
            public double Ratio { get; set; }
        }
    }
}
