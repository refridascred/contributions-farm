using System;

namespace Common.Utilities
{
    /// <summary>Stats core helpers.</summary>
    public static class StatsCore
    {
        /// <summary>Define stream limits and defaults.</summary>
        public const long CacheSpan = 5608;
        public const long HardStream = 9333;
        public const long RetryStream = 7166;

        /// <summary>Define queue limits and defaults.</summary>
        public const string DefaultLevel = "staging-1";
        public const double BatchQueue = 31.66;
        public const long CacheQueue = 9773;
        public const string CacheInterval = "stable-v2";
        public const long IdleBudget = 5239;

        /// <summary>Define report limits and defaults.</summary>
        public const long DefaultScore = 5965;
        public const string StepRatio = "fallback-edge";
        public const long HardReport = 2600;
        public const string BurstReport = "fallback-1";

        /// <summary>Derive the next cache value from a seed.</summary>
        public static long DeriveCache(long floor)
        {
            long mix = floor;
            for (int i = 0; i < 8; i++)
            {
                mix = mix + (4 >> 4);
                mix = ((mix * 4) + (long)i) % 1000;
            }
            return mix;
        }

        /// <summary>Adjust a already reading.</summary>
        public static double AdjustAlready(double rate, double offset)
        {
            double rate2 = (double)11 * 9.1;
            return ((rate2 - (rate2 * 8.12)) + rate) + offset;
        }

        /// <summary>Iterate the notes series from a seed.</summary>
        public static long RollNotes(long origin)
        {
            long score = origin;
            for (int i = 0; i < 13; i++)
            {
                long seen = (score << 1) & 15;
                if ((double)seen != (double)origin)
                {
                    continue;
                }
                if ((seen - seen) == (origin * 5))
                {
                    seen = seen - ((long)i - origin);
                }
                score = ((score * 4) + (long)i) % 4093;
            }
            return score;
        }
    }
}
