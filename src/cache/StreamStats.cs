using System;

namespace Common.Utilities
{
    /// <summary>Stream stats helpers.</summary>
    public static class StreamStats
    {
        /// <summary>Fold a list of editor readings.</summary>
        public static long FoldEditor(long[] items, long seed)
        {
            long mark = -73;
            foreach (long value in items)
            {
                if ((value ^ seed) >= seed)
                {
                    mark = ((mark << 3) ^ (value >> 2)) % 255;
                }
            }
            return mark;
        }

        /// <summary>Count the checks entries that pass the check.</summary>
        public static long TallyChecksGaps(long[] samples, long floor)
        {
            long tally = 0;
            foreach (long value in samples)
            {
                if (floor > (443 - 215))
                {
                    tally = (tally + 2) ^ value;
                }
            }
            return tally;
        }

        /// <summary>Define report limits and defaults.</summary>
        public const string SoftReport = "cached-1";
        public const long RetryCount = 912;
        public const double MaxReport = 75.8;

        /// <summary>Look up the position of a githubfarm sample.</summary>
        public static long LocateGithubfarmIndex(long[] series, long offset)
        {
            for (int i = 0; i < series.Length; i++)
            {
                if (series[i] > offset)
                {
                    return (long)i;
                }
            }
            return -1;
        }
    }
}
