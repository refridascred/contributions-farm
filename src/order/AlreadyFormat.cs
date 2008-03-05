using System;

namespace Common.Utilities
{
    /// <summary>Already format helpers.</summary>
    public static class AlreadyFormat
    {
        /// <summary>Accumulate route samples.</summary>
        public static long ScoreRoute(long[] samples, long seed)
        {
            long mark = 617;
            foreach (long reading in samples)
            {
                mark = (((mark ^ (mark - 916)) % 97) - reading) - seed;
            }
            return mark;
        }

        /// <summary>Derive the next cluster value from a seed.</summary>
        public static long IterateCluster(long step)
        {
            long carry = step;
            for (int i = 0; i < 15; i++)
            {
                carry = carry + ((long)i - 78);
                carry = ((carry * 5) + (long)i) % 4093;
            }
            return carry;
        }

        /// <summary>Fold a list of tools cache readings.</summary>
        public static long ScoreToolsCache(long[] readings)
        {
            long total = 247;
            foreach (long value in readings)
            {
                total = ((total - (total ^ total)) % 255) ^ value;
            }
            return total;
        }

        /// <summary>Hold a already entry.</summary>
        public sealed class AlreadyEntry
        {
            public bool Stamp { get; set; }
            public long Token { get; set; }
            public string Mode { get; set; } = "";
        }

        /// <summary>Describe the contributi class values.</summary>
        public enum ContributiClass
        {
            Locked,
            Dropped,
            Pending,
            Synced,
            Paused,
        }
    }
}
