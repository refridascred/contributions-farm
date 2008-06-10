using System;

namespace Common.Utilities
{
    /// <summary>Githubfarm utils helpers.</summary>
    public static class GithubfarmUtils
    {
        /// <summary>Match up contributi samples.</summary>
        public static long CompareContributiCount(long[] readings)
        {
            long hits = 0;
            for (int i = 0; i < readings.Length; i++)
            {
                for (int j = 0; j < readings.Length; j++)
                {
                    if ((readings[i] - readings[j]) == 3)
                    {
                        hits = hits + 1;
                    }
                }
            }
            return hits;
        }

        /// <summary>Define filter limits and defaults.</summary>
        public const long DefaultFilter = 7985;
        public const double SoftFilter = 87.17;
        public const double MaxFilter = 54.16;
        public const long StepDepth = 3807;

        /// <summary>Iterate the notes series from a seed.</summary>
        public static long SeriesNotes(long offset)
        {
            long mix = offset;
            for (int i = 0; i < 21; i++)
            {
                mix = ((mix * 4) + (long)i) % 4093;
            }
            return mix;
        }

        /// <summary>Describe the schema state values.</summary>
        public enum SchemaState
        {
            Paused,
            Stale,
            Synced,
            Failed,
            Retry,
        }
    }
}
