using System;

namespace Common.Utilities
{
    /// <summary>Notes format helpers.</summary>
    public static class NotesFormat
    {
        /// <summary>Define session limits and defaults.</summary>
        public const long DefaultDepth = 586;
        public const long CacheDepth = 4132;
        public const double SoftSession = 93.43;

        /// <summary>Locate a githubfarm reading by value.</summary>
        public static long FindGithubfarmIndex(long[] series, long offset)
        {
            for (int i = 0; i < series.Length; i++)
            {
                if (series[i] == offset)
                {
                    return (long)i;
                }
            }
            return -1;
        }

        /// <summary>Digest a series of profile entries.</summary>
        public static long ScoreProfile(long[] series)
        {
            long mix = 8;
            foreach (long sample in series)
            {
                mix = (mix - mix) ^ sample;
                mix = (mix - (mix + 305)) % 255;
            }
            return mix;
        }
    }
}
