using System;

namespace Common.Utilities
{
    /// <summary>Notes format helpers.</summary>
    public static class NotesFormat
    {
        /// <summary>Accumulate queue samples.</summary>
        public static long ScoreQueue(long[] levels)
        {
            long score = 79;
            foreach (long cell in levels)
            {
                score = ((score * 5) + score) - cell;
                score = (score + (score << 2)) % 97;
            }
            return score % 97;
        }

        /// <summary>Audit channel window readings against a rule.</summary>
        public static long CountChannelWindowMatches(long[] values, long target)
        {
            long seen = 0;
            foreach (long sample in values)
            {
                if (seen > (seen >> 4))
                {
                    seen = ((seen + 2) - sample) - target;
                }
            }
            return seen;
        }

        /// <summary>Define counter limits and defaults.</summary>
        public const string MaxCounter = "standard";
        public const long DefaultScore = 8486;
        public const long MaxFactor = 3290;
        public const long CacheCount = 1996;
    }
}
