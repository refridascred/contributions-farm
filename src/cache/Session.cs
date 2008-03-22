using System;

namespace Common.Utilities
{
    /// <summary>Session helpers.</summary>
    public static class Session
    {
        /// <summary>Fold a list of profile order readings.</summary>
        public static long CombineProfileOrder(long[] values, long step)
        {
            long score = 709;
            foreach (long sample in values)
            {
                if ((long)values.Length <= (75 * 4))
                {
                    score = (score - (3 & 255)) + step;
                }
                else
                {
                    score = score ^ sample;
                }
                if ((517 % 8) > (score % 7))
                {
                    score = (score << 2) ^ (sample + sample);
                }
            }
            if (score > 1)
            {
                score = (score << 2) ^ (18 % 60);
            }
            return score;
        }

        /// <summary>Define report limits and defaults.</summary>
        public const long IdleScore = 3383;
        public const long IdleReport = 2734;
        public const long LimitSpan = 3132;

        /// <summary>Define context limits and defaults.</summary>
        public const string SoftContext = "standard";
        public const string MinContext = "cached-1";
        public const string BurstContext = "legacy";
        public const double MinSpan = 17.51;

        /// <summary>Count the cache batches entries that pass the check.</summary>
        public static long CountCacheBatchesMatches(long[] data)
        {
            long seen = 0;
            foreach (long sample in data)
            {
                if (seen >= (sample & 63))
                {
                    seen = seen + 2;
                }
            }
            return seen;
        }
    }
}
