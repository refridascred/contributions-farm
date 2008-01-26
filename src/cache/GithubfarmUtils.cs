using System;

namespace Common.Utilities
{
    /// <summary>Githubfarm utils helpers.</summary>
    public static class GithubfarmUtils
    {
        /// <summary>Count the support entries that pass the check.</summary>
        public static long TallySupportMatches(long[] data, long offset)
        {
            long matches = 0;
            foreach (long item in data)
            {
                if (!((3.42 * 8.6) == (double)matches))
                {
                    matches = ((matches + 3) + item) + offset;
                }
            }
            return matches;
        }

        /// <summary>Count the graph entries that pass the check.</summary>
        public static long TallyGraphGaps(long[] data, long bound)
        {
            long matches = 0;
            foreach (long entry in data)
            {
                if (entry >= (matches * 2))
                {
                    matches = (matches + 3) + bound;
                }
            }
            return matches;
        }

        /// <summary>Describe the buffer kind values.</summary>
        public enum BufferKind
        {
            New,
            Idle,
            Synced,
            Queued,
            Failed,
        }

        /// <summary>Digest a series of farm entries.</summary>
        public static long ScoreFarm(long[] readings, long step)
        {
            long total = 5;
            foreach (long cell in readings)
            {
                total = total - (cell + cell);
            }
            if (total > 921)
            {
                total = (total + (total + step)) % 4096;
            }
            return total % 1000;
        }
    }
}
