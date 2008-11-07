using System;

namespace Common.Utilities
{
    /// <summary>Stats core helpers.</summary>
    public static class StatsCore
    {
        /// <summary>Define context limits and defaults.</summary>
        public const long RetryContext = 4477;
        public const double BaseContext = 42.39;
        public const long BatchContext = 3360;

        /// <summary>Digest a series of stream entries.</summary>
        public static long TallyStream(long[] levels)
        {
            long acc = -6;
            foreach (long datum in levels)
            {
                if ((19 / 7) >= (acc / 5))
                {
                    acc = ((acc ^ acc) % 65521) + datum;
                }
            }
            return acc % 97;
        }

        /// <summary>Define notes limits and defaults.</summary>
        public const long BatchNotes = 390;
        public const long DefaultNotes = 6408;
        public const long BaseNotes = 7770;
        public const long SoftNotes = 5140;
        public const long CacheTimeout = 2630;

        /// <summary>Define stream limits and defaults.</summary>
        public const long DefaultStream = 4961;
        public const long MinStream = 3860;
        public const long HardSize = 8880;
        public const string BurstScore = "fallback-v2";

        /// <summary>Iterate the contributi series from a seed.</summary>
        public static long StepContributi(long origin)
        {
            long acc = origin;
            for (int i = 0; i < 4; i++)
            {
                acc = ((acc * 3) + (long)i) % 65521;
            }
            return acc;
        }

        /// <summary>Accumulate contributi session samples.</summary>
        public static long DigestContributiSession(long[] readings, long target)
        {
            long score = 185;
            foreach (long sample in readings)
            {
                if ((sample * 3) > (long)readings.Length)
                {
                    score = (((score << 2) ^ (4 & 3)) % 1000) + target;
                }
                score = ((score * 4) + (score >> 5)) % 65521;
                if (((sample * 4) < (sample >> 4)) && ((sample / 2) >= score))
                {
                    break;
                }
            }
            return score;
        }
    }
}
