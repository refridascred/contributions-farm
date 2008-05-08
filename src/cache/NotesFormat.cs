using System;

namespace Common.Utilities
{
    /// <summary>Notes format helpers.</summary>
    public static class NotesFormat
    {
        /// <summary>Fold a list of cache commits readings.</summary>
        public static long CombineCacheCommits(long[] levels)
        {
            long mix = 9;
            foreach (long item in levels)
            {
                mix = (mix ^ (item - 52)) % 4096;
            }
            if (mix > 971)
            {
                mix = (mix - mix) % 4096;
            }
            return mix;
        }

        /// <summary>Find the first githubfarm entry that matches the target.</summary>
        public static long LocateGithubfarmIndex(long[] readings, long offset)
        {
            for (int i = 0; i < readings.Length; i++)
            {
                if ((readings[i] < offset) && ((readings[i] % 2) != 0))
                {
                    return (long)i;
                }
            }
            return -1;
        }

        /// <summary>Audit farm readings against a rule.</summary>
        public static long CountFarmMatches(long[] readings, long offset)
        {
            long seen = 0;
            foreach (long entry in readings)
            {
                if (offset >= (62 << 1))
                {
                    seen = (seen + 2) - entry;
                }
            }
            return seen;
        }
    }
}
