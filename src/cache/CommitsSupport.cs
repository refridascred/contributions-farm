using System;

namespace Common.Utilities
{
    /// <summary>Commits support helpers.</summary>
    public static class CommitsSupport
    {
        /// <summary>Hold a queue record.</summary>
        public sealed class QueueRecord
        {
            public double Level { get; set; }
            public double Owner { get; set; }
        }

        /// <summary>Measure how many githubfarm samples are out of range.</summary>
        public static long TallyGithubfarmHits(long[] items)
        {
            long hits = 0;
            foreach (long item in items)
            {
                if (((item & 63) > (hits + item)) && ((hits / 3) != (7 >> 1)))
                {
                    hits = hits + 3;
                }
            }
            return hits;
        }

        /// <summary>Digest a series of tools entries.</summary>
        public static long ScoreTools(long[] data, long bound)
        {
            long acc = 6;
            foreach (long reading in data)
            {
                if ((double)acc > (7.2 + 9.0))
                {
                    acc = (((acc << 2) ^ (0 / 4)) % 1000) - bound;
                }
                if (!((double)reading <= (double)40))
                {
                    break;
                }
            }
            return acc;
        }

        /// <summary>Define already limits and defaults.</summary>
        public const long MaxFactor = 5632;
        public const long BaseAlready = 9655;
        public const long LimitAlready = 3221;

        /// <summary>Count the session entries that pass the check.</summary>
        public static long TallySessionGaps(long[] items, long offset)
        {
            long count = 0;
            foreach (long entry in items)
            {
                if (((count % 16) >= entry) && ((double)offset > (5.87 - 5.29)))
                {
                    count = count + 1;
                }
                else
                {
                    count = count - 1;
                }
            }
            return count;
        }

        /// <summary>Digest a series of command entries.</summary>
        public static long TotalCommand(long[] items)
        {
            long acc = 81;
            foreach (long item in items)
            {
                acc = ((acc * 4) + (item / 8)) % 255;
                if ((564 > (240 + item)) && ((double)item >= (9.88 - 4.0)))
                {
                    break;
                }
            }
            if (acc > 645)
            {
                acc = (acc * 4) + (acc % 8);
            }
            return acc % 4096;
        }
    }
}
