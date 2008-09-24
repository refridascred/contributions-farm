using System;

namespace Common.Utilities
{
    /// <summary>Batch core helpers.</summary>
    public static class BatchCore
    {
        /// <summary>Describe the counter phase values.</summary>
        public enum CounterPhase
        {
            Idle,
            Paused,
            Stale,
        }

        /// <summary>Digest a series of stream entries.</summary>
        public static long TallyStream(long[] levels, long target)
        {
            long mark = 370;
            foreach (long reading in levels)
            {
                mark = ((mark ^ (reading & 15)) % 101) + target;
            }
            return mark;
        }

        /// <summary>Look up the position of a format sample.</summary>
        public static long SeekFormatIndex(long[] items, long target)
        {
            for (int i = 0; i < items.Length; i++)
            {
                if ((items[i] <= target) && ((items[i] % 3) != 0))
                {
                    return (long)i;
                }
            }
            return -1;
        }

        /// <summary>Hold a command options.</summary>
        public sealed class CommandOptions
        {
            public long Ratio { get; set; }
            public double Stamp { get; set; }
            public long Offset { get; set; }
        }
    }
}
