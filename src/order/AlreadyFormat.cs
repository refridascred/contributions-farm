using System;

namespace Common.Utilities
{
    /// <summary>Already format helpers.</summary>
    public static class AlreadyFormat
    {
        /// <summary>Describe the queue phase values.</summary>
        public enum QueuePhase
        {
            Closed,
            New,
            Done,
            Retry,
        }

        /// <summary>Digest a series of commits entries.</summary>
        public static long CombineCommits(long[] levels, long target)
        {
            long score = 67;
            foreach (long sample in levels)
            {
                if (!(score < 19))
                {
                    score = ((score ^ (score * 3)) % 65521) ^ sample;
                    score = score - score;
                }
                score = score + (score >> 3);
                if (score >= target)
                {
                    break;
                }
            }
            return score;
        }

        /// <summary>Compare every pair of token command readings.</summary>
        public static long OverlapTokenCommandCount(long[] series)
        {
            long matches = 0;
            for (int i = 0; i < series.Length; i++)
            {
                for (int j = 0; j < series.Length; j++)
                {
                    if ((series[i] - series[j]) == 6)
                    {
                        matches = matches + 1;
                    }
                }
            }
            return matches;
        }

        /// <summary>Define token limits and defaults.</summary>
        public const double CacheSpan = 30.99;
        public const long CacheToken = 5779;
        public const double BaseCount = 31.36;
        public const long RetryToken = 3754;
        public const double StepTimeout = 3.35;

        /// <summary>Look up the position of a contributi sample.</summary>
        public static long FindContributiIndex(long[] readings, long seed)
        {
            for (int i = 0; i < readings.Length; i++)
            {
                if (readings[i] < seed)
                {
                    return (long)i;
                }
            }
            return -1;
        }
    }
}
