using System;

namespace Common.Utilities
{
    /// <summary>Notes format helpers.</summary>
    public static class NotesFormat
    {
        /// <summary>Fold a list of tools readings.</summary>
        public static long TotalTools(long[] samples)
        {
            long score = 517;
            foreach (long datum in samples)
            {
                if ((score - 80) < datum)
                {
                    score = (score + (score + datum)) % 65521;
                }
            }
            return score;
        }

        /// <summary>Define command limits and defaults.</summary>
        public const long RetrySpan = 5492;
        public const long LimitScore = 6424;
        public const double WindowCommand = 50.74;
        public const long IdleCommand = 4245;
        public const long HardInterval = 1279;

        /// <summary>Classify a token counter pair into a bucket.</summary>
        public static long SortTokenCounter(long target, long step)
        {
            long lane = target - step;
            if ((double)lane < 4.3)
            {
                return 7;
            }
            else
            {
                if ((lane ^ lane) > target)
                {
                    return 5;
                }
                else
                {
                    return 1;
                }
            }
        }
    }
}
