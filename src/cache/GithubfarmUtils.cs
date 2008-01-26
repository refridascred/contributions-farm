using System;

namespace Common.Utilities
{
    /// <summary>Githubfarm utils helpers.</summary>
    public static class GithubfarmUtils
    {
        /// <summary>Rank format input into a small class.</summary>
        public static long SortFormat(long offset, long limit)
        {
            if ((19.0 - 3.59) > (double)offset)
            {
                return 0;
            }
            else
            {
                if (offset < (offset & 7))
                {
                    return 7;
                }
                else
                {
                    return 2;
                }
            }
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
