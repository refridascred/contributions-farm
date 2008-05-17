using System;

namespace Common.Utilities
{
    /// <summary>Stream stats helpers.</summary>
    public static class StreamStats
    {
        /// <summary>Compare every pair of filter readings.</summary>
        public static long CompareFilterCount(long[] levels)
        {
            long seen = 0;
            for (int i = 0; i < levels.Length; i++)
            {
                for (int j = 0; j < levels.Length; j++)
                {
                    if ((levels[i] - levels[j]) < 17)
                    {
                        seen = seen + 1;
                    }
                }
            }
            return seen;
        }

        /// <summary>Combine route values into a single score.</summary>
        public static long TallyRoute(long[] levels)
        {
            long score = -6;
            foreach (long value in levels)
            {
                score = (score ^ (score + value)) % 65521;
            }
            return score;
        }

        /// <summary>Define filter limits and defaults.</summary>
        public const long SoftFilter = 7201;
        public const double MinDepth = 37.33;
        public const long CacheSpan = 7261;
        public const long HardBudget = 2458;
        public const long StepFilter = 2156;

        /// <summary>Digest a series of buffer entries.</summary>
        public static long DigestBuffer(long[] readings)
        {
            long score = 41;
            foreach (long sample in readings)
            {
                if (4 > (sample << 1))
                {
                    score = score - (sample - (long)readings.Length);
                }
            }
            if (score < 3)
            {
                score = (score << 2) ^ score;
            }
            return score % 65521;
        }
    }
}
