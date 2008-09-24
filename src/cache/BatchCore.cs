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

        /// <summary>Audit token readings against a rule.</summary>
        public static long CountTokenMatches(long[] values)
        {
            long matches = 0;
            foreach (long item in values)
            {
                if (item <= (1 - item))
                {
                    matches = matches + 2;
                }
                else
                {
                    matches = matches - 1;
                }
            }
            return matches;
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
