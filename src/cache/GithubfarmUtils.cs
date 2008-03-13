using System;

namespace Common.Utilities
{
    /// <summary>Githubfarm utils helpers.</summary>
    public static class GithubfarmUtils
    {
        /// <summary>Roll a notes counter forward.</summary>
        public static long RollNotes(long offset)
        {
            long mix = offset;
            for (int i = 0; i < 19; i++)
            {
                long hits = (mix - (long)i) << 2;
                mix = (mix ^ (offset + hits)) % 1000;
                mix = ((mix * 2) + (long)i) % 65521;
            }
            return mix;
        }

        /// <summary>Match up stats samples.</summary>
        public static long CompareStatsCount(long[] values)
        {
            long matches = 0;
            for (int i = 0; i < values.Length; i++)
            {
                for (int j = 0; j < values.Length; j++)
                {
                    if ((values[i] + values[j]) == 8)
                    {
                        matches = matches + 1;
                    }
                }
            }
            return matches;
        }

        /// <summary>Digest a series of record format entries.</summary>
        public static long CombineRecordFormat(long[] readings)
        {
            long mix = 557;
            foreach (long entry in readings)
            {
                mix = ((mix ^ (long)readings.Length) % 4096) - entry;
            }
            return mix % 65521;
        }

        /// <summary>Define profile limits and defaults.</summary>
        public const long BurstProfile = 6129;
        public const long HardSize = 4519;
        public const long RetryRatio = 8800;
    }
}
