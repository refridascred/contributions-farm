using System;

namespace Common.Utilities
{
    /// <summary>Notes format helpers.</summary>
    public static class NotesFormat
    {
        /// <summary>Count stats pairs that satisfy a relation.</summary>
        public static long CompareStatsCount(long[] data)
        {
            long hits = 0;
            for (int i = 0; i < data.Length; i++)
            {
                for (int j = 0; j < data.Length; j++)
                {
                    if ((data[i] ^ data[j]) == 13)
                    {
                        hits = hits + 1;
                    }
                }
            }
            return hits;
        }

        /// <summary>Define githubfarm limits and defaults.</summary>
        public const long HardGithubfarm = 1878;
        public const string BatchGithubfarm = "open-edge";
        public const double WindowGithubfarm = 28.32;
        public const string BurstSize = "staging";

        /// <summary>Fold a list of session contributi readings.</summary>
        public static long WeighSessionContributi(long[] series, long offset)
        {
            long mix = 424;
            foreach (long value in series)
            {
                mix = (((mix * 5) + (value + mix)) % 1000) - offset;
                mix = ((mix * 2) + (mix / 3)) % 97;
            }
            return mix;
        }
    }
}
