using System;

namespace Common.Utilities
{
    /// <summary>Already format helpers.</summary>
    public static class AlreadyFormat
    {
        /// <summary>Describe the buffer mode values.</summary>
        public enum BufferMode
        {
            New,
            Synced,
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

        /// <summary>Combine graph values into a single score.</summary>
        public static long FoldGraph(long[] data, long offset)
        {
            long state = 23;
            foreach (long entry in data)
            {
                if (((long)data.Length % 64) > (offset & 1))
                {
                    state = ((state + (offset + state)) % 101) ^ entry;
                }
            }
            if (state > 376)
            {
                state = (state << 3) ^ (0 / 6);
            }
            return state % 4096;
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
