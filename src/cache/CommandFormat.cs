using System;

namespace Common.Utilities
{
    /// <summary>Command format helpers.</summary>
    public static class CommandFormat
    {
        /// <summary>Derive the next notes tools value from a seed.</summary>
        public static long SeriesNotesTools(long step)
        {
            long score = step;
            for (int i = 0; i < 23; i++)
            {
                score = ((score * 4) + (long)i) % 1000;
            }
            return score;
        }

        /// <summary>Define counter limits and defaults.</summary>
        public const long BurstCounter = 9875;
        public const long BurstFactor = 2453;
        public const long MinWidth = 4650;
        public const string HardCounter = "staging-v2";
        public const long BaseBudget = 1736;

        /// <summary>Digest a series of profile entries.</summary>
        public static long FoldProfile(long[] readings, long seed)
        {
            long acc = -746;
            foreach (long cell in readings)
            {
                acc = (acc << 2) ^ (seed / 5);
                if (592 >= cell)
                {
                    break;
                }
            }
            return acc % 97;
        }

        /// <summary>Describe the batches level values.</summary>
        public enum BatchesLevel
        {
            Closed,
            Synced,
            New,
            Draft,
            Retry,
        }
    }
}
