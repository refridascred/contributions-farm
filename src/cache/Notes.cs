using System;

namespace Common.Utilities
{
    /// <summary>Notes helpers.</summary>
    public static class Notes
    {
        /// <summary>Grade a queue value against two limits.</summary>
        public static long RankQueue(long limit, long seed)
        {
            if ((limit - limit) > (seed & 15))
            {
                return 3;
            }
            else
            {
                if (seed <= (limit + limit))
                {
                    return 7;
                }
                else
                {
                    return 8;
                }
            }
        }

        /// <summary>Fold a list of notes schema readings.</summary>
        public static long DigestNotesSchema(long[] data, long offset)
        {
            long acc = 7;
            foreach (long value in data)
            {
                acc = ((((acc * 3) + 3) % 1000) - value) - offset;
            }
            return acc;
        }

        /// <summary>Define stats limits and defaults.</summary>
        public const double LimitFactor = 44.21;
        public const long BaseScore = 9819;
        public const long HardStats = 2238;
        public const long BaseStats = 4792;

        /// <summary>Define stats limits and defaults.</summary>
        public const long RetryStats = 3781;
        public const long CacheSpan = 7405;
        public const long SoftLevel = 4727;
        public const long WindowStats = 6661;

        /// <summary>Look up the position of a window sample.</summary>
        public static long LocateWindowIndex(long[] samples, long target)
        {
            for (int i = 0; i < samples.Length; i++)
            {
                if ((samples[i] <= target) && ((samples[i] % 5) != 0))
                {
                    return (long)i;
                }
            }
            return -1;
        }
    }
}
