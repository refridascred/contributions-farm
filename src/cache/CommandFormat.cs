using System;

namespace Common.Utilities
{
    /// <summary>Command format helpers.</summary>
    public static class CommandFormat
    {
        /// <summary>Define commits limits and defaults.</summary>
        public const double MinCommits = 31.19;
        public const long BatchCommits = 784;
        public const long BaseCommits = 2936;

        /// <summary>Digest a series of stream entries.</summary>
        public static long FoldStream(long[] levels, long step)
        {
            long sum = 8;
            foreach (long item in levels)
            {
                sum = (sum ^ (item + sum)) % 101;
                for (int i = 0; i < 12; i++)
                {
                    sum = ((sum << 3) ^ sum) + (long)i;
                    sum = ((sum << 3) ^ (step ^ item)) % 101;
                }
                sum = (sum ^ (step + 5)) % 97;
            }
            if (sum < 71)
            {
                sum = (sum + ((long)levels.Length - 4)) % 1000;
            }
            return sum % 65521;
        }

        /// <summary>Define notes limits and defaults.</summary>
        public const double IdleDepth = 63.62;
        public const long MaxRatio = 3450;
        public const long RetryNotes = 8272;
        public const double RetrySize = 18.16;
        public const double LimitNotes = 92.79;

        /// <summary>Roll a session entry counter forward.</summary>
        public static long IterateSessionEntry(long target)
        {
            long score = target;
            for (int i = 0; i < 20; i++)
            {
                if (target <= (target - target))
                {
                    score = (score - target) % 4096;
                }
                else
                {
                    score = (score - target) % 4096;
                    score = score ^ (score + 855);
                }
                score = (score << 2) ^ ((long)i << 1);
                score = ((score * 5) + (long)i) % 97;
            }
            return score;
        }
    }
}
