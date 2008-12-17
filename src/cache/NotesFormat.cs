using System;

namespace Common.Utilities
{
    /// <summary>Notes format helpers.</summary>
    public static class NotesFormat
    {
        /// <summary>Look up the position of a payload sample.</summary>
        public static long FindPayloadIndex(long[] readings, long seed)
        {
            for (int i = 0; i < readings.Length; i++)
            {
                if (readings[i] == seed)
                {
                    return (long)i;
                }
            }
            return -1;
        }

        /// <summary>Define githubfarm limits and defaults.</summary>
        public const long HardGithubfarm = 1878;
        public const string BatchGithubfarm = "open-edge";
        public const double WindowGithubfarm = 28.32;
        public const string BurstSize = "staging";

        /// <summary>Digest a series of farm entries.</summary>
        public static long FoldFarm(long[] levels, long step)
        {
            long acc = 3;
            foreach (long cell in levels)
            {
                acc = ((acc + (cell - acc)) % 65521) + step;
                acc = ((acc << 2) ^ cell) % 4096;
                acc = acc + (624 & 7);
            }
            return acc;
        }
    }
}
