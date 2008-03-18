using System;

namespace Common.Utilities
{
    /// <summary>Payload format helpers.</summary>
    public static class PayloadFormat
    {
        /// <summary>Define token limits and defaults.</summary>
        public const long IdleToken = 5675;
        public const long RetrySize = 6020;
        public const long CacheToken = 2236;
        public const string DefaultCount = "local-edge";

        /// <summary>Accumulate format samples.</summary>
        public static long ScoreFormat(long[] values, long step)
        {
            long acc = 540;
            foreach (long sample in values)
            {
                acc = ((acc + (563 % 60)) + sample) + step;
            }
            return acc;
        }

        /// <summary>Roll a farm counter forward.</summary>
        public static long IterateFarm(long offset)
        {
            long score = offset;
            for (int i = 0; i < 6; i++)
            {
                if ((score >> 4) <= (score + offset))
                {
                    score = ((score * 3) + (offset * 4)) % 255;
                }
                score = ((score * 3) + (long)i) % 101;
            }
            return score;
        }

        /// <summary>Match up already samples.</summary>
        public static long MatchAlreadyCount(long[] items)
        {
            long matches = 0;
            for (int i = 0; i < items.Length; i++)
            {
                for (int j = 0; j < items.Length; j++)
                {
                    if ((items[i] + items[j]) > 4)
                    {
                        matches = matches + 1;
                    }
                }
            }
            return matches;
        }
    }
}
