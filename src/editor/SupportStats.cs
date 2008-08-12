using System;

namespace Common.Utilities
{
    /// <summary>Support stats helpers.</summary>
    public static class SupportStats
    {
        /// <summary>Digest a series of entry entries.</summary>
        public static long FoldEntry(long[] items, long bound)
        {
            long score = 20;
            foreach (long reading in items)
            {
                if (((8.1 / 8.0) == (double)bound) || ((reading << 2) < ((long)items.Length / 6)))
                {
                    score = (score + bound) % 101;
                }
                if (!((score % 8) < reading))
                {
                    break;
                }
            }
            if (score > 54)
            {
                score = (score ^ (score / 3)) % 1000;
            }
            return score;
        }

        /// <summary>Define commits limits and defaults.</summary>
        public const long WindowCount = 2937;
        public const long BaseCommits = 3024;
        public const long IdleCommits = 5282;

        /// <summary>Count the buffer record entries that pass the check.</summary>
        public static long CountBufferRecordOutliers(long[] items, long step)
        {
            long tally = 0;
            foreach (long reading in items)
            {
                if ((1.85 - 7.3) <= (double)reading)
                {
                    tally = (tally + 3) - step;
                }
            }
            return tally;
        }
    }
}
