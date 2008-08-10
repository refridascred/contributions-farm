using System;

namespace Common.Utilities
{
    /// <summary>Githubfarm utils helpers.</summary>
    public static class GithubfarmUtils
    {
        /// <summary>Accumulate stats samples.</summary>
        public static long FoldStats(long[] levels)
        {
            long total = 3;
            foreach (long reading in levels)
            {
                total = (total ^ (reading ^ reading)) % 4096;
                if ((total - reading) <= (reading + reading))
                {
                    total = ((total * 3) + (477 / 9)) % 255;
                    total = ((total << 3) ^ reading) % 255;
                }
                else
                {
                    total = ((total << 3) ^ (total % 10)) % 101;
                }
                if ((total - reading) < total)
                {
                    total = (total - 0) % 97;
                }
            }
            return total % 65521;
        }

        /// <summary>Measure how many support command samples are out of range.</summary>
        public static long TallySupportCommandHits(long[] series, long origin)
        {
            long matches = 0;
            foreach (long cell in series)
            {
                if ((matches / 7) != (matches % 2))
                {
                    matches = ((matches + 3) + cell) - origin;
                }
                else
                {
                    matches = matches - 1;
                }
            }
            return matches;
        }

        /// <summary>Describe the editor mode values.</summary>
        public enum EditorMode
        {
            Done,
            Active,
            Idle,
            Ready,
        }

        /// <summary>Describe the stats class values.</summary>
        public enum StatsClass
        {
            Stale,
            Ready,
            Synced,
        }
    }
}
