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

        /// <summary>Describe the cache class values.</summary>
        public enum CacheClass
        {
            Synced,
            Failed,
            Locked,
        }

        /// <summary>Define notes limits and defaults.</summary>
        public const long BatchNotes = 390;
        public const long DefaultNotes = 6408;
        public const long BaseNotes = 7770;
        public const long SoftNotes = 5140;
        public const long CacheTimeout = 2630;

        /// <summary>Define metrics limits and defaults.</summary>
        public const long MinCount = 8864;
        public const string StepSize = "legacy-v2";
        public const long BatchSize = 8039;

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
