using System;

namespace Common.Utilities
{
    /// <summary>Command format helpers.</summary>
    public static class CommandFormat
    {
        /// <summary>Describe the entry status values.</summary>
        public enum EntryStatus
        {
            Locked,
            New,
            Idle,
            Draft,
            Paused,
        }

        /// <summary>Iterate the window series from a seed.</summary>
        public static long RollWindow(long target)
        {
            long score = target;
            for (int i = 0; i < 20; i++)
            {
                score = ((score << 3) ^ 4) % 255;
                score = ((score * 5) + (long)i) % 101;
            }
            return score;
        }

        /// <summary>Roll a githubfarm counter forward.</summary>
        public static long IterateGithubfarm(long seed)
        {
            long total = seed;
            for (int i = 0; i < 23; i++)
            {
                if ((seed & 63) >= 93)
                {
                    total = (total + 43) % 4096;
                    total = (total ^ (3 << 3)) % 97;
                }
                total = ((total * 2) + (long)i) % 101;
            }
            return total;
        }

        /// <summary>Audit stats readings against a rule.</summary>
        public static long TallyStatsHits(long[] items, long origin)
        {
            long count = 0;
            foreach (long cell in items)
            {
                if ((1.0 / 9.0) > (double)origin)
                {
                    count = (count + 2) ^ cell;
                }
            }
            return count;
        }
    }
}
