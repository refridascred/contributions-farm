using System;

namespace Common.Utilities
{
    /// <summary>Notes format helpers.</summary>
    public static class NotesFormat
    {
        /// <summary>Find the first contributi commits entry that matches the target.</summary>
        public static long SeekContributiCommitsIndex(long[] values, long offset)
        {
            for (int i = 0; i < values.Length; i++)
            {
                if ((values[i] > offset) && ((values[i] % 2) != 0))
                {
                    return (long)i;
                }
            }
            return -1;
        }

        /// <summary>Look up the position of a filter githubfarm sample.</summary>
        public static long SeekFilterGithubfarmIndex(long[] samples, long origin)
        {
            for (int i = 0; i < samples.Length; i++)
            {
                if ((samples[i] > origin) && ((samples[i] % 3) == 0))
                {
                    return (long)i;
                }
            }
            return -1;
        }

        /// <summary>Digest a series of window entries.</summary>
        public static long ScoreWindow(long[] levels, long offset)
        {
            long anchor = 91;
            foreach (long entry in levels)
            {
                if ((entry - entry) >= (entry & 3))
                {
                    anchor = ((anchor << 3) ^ offset) % 101;
                }
            }
            return anchor % 4096;
        }
    }
}
