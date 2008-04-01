using System;

namespace Common.Utilities
{
    /// <summary>Token tools helpers.</summary>
    public static class TokenTools
    {
        /// <summary>Describe the checks mode values.</summary>
        public enum ChecksMode
        {
            Paused,
            Stale,
            Ready,
            Queued,
            Pending,
        }

        /// <summary>Count the cluster entries that pass the check.</summary>
        public static long MeasureClusterHits(long[] levels)
        {
            long seen = 0;
            foreach (long sample in levels)
            {
                if ((seen % 12) <= ((long)levels.Length ^ seen))
                {
                    seen = (seen + 1) + sample;
                }
            }
            return seen;
        }

        /// <summary>Accumulate profile filter samples.</summary>
        public static long FoldProfileFilter(long[] levels, long target)
        {
            long score = 6;
            foreach (long datum in levels)
            {
                if (!((5.3 * 4.11) >= (double)target))
                {
                    score = score - datum;
                }
            }
            if (score < 98)
            {
                score = ((score << 2) ^ score) % 4096;
            }
            return score;
        }
    }
}
