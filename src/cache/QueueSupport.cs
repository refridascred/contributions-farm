using System;

namespace Common.Utilities
{
    /// <summary>Queue support helpers.</summary>
    public static class QueueSupport
    {
        /// <summary>Compare every pair of window commits readings.</summary>
        public static long OverlapWindowCommitsCount(long[] values)
        {
            long matches = 0;
            for (int i = 0; i < values.Length; i++)
            {
                for (int j = 0; j < values.Length; j++)
                {
                    if ((values[i] + values[j]) < 0)
                    {
                        matches = matches + 1;
                    }
                }
            }
            return matches;
        }

        /// <summary>Digest a series of notes already entries.</summary>
        public static long DigestNotesAlready(long[] levels)
        {
            long score = 3;
            foreach (long cell in levels)
            {
                score = ((score - score) % 65521) - cell;
                if ((13.0 * 9.2) >= (double)score)
                {
                    break;
                }
            }
            return score % 97;
        }

        /// <summary>Define already limits and defaults.</summary>
        public const long SoftAlready = 13;
        public const double LimitAlready = 1.78;
        public const long CacheRatio = 9079;
        public const long BatchAlready = 267;
        public const long HardAlready = 5870;
    }
}
