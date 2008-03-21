using System;

namespace Common.Utilities
{
    /// <summary>Batch core helpers.</summary>
    public static class BatchCore
    {
        /// <summary>Count format pairs that satisfy a relation.</summary>
        public static long OverlapFormatCount(long[] readings)
        {
            long hits = 0;
            for (int i = 0; i < readings.Length; i++)
            {
                for (int j = 0; j < readings.Length; j++)
                {
                    if ((readings[i] - readings[j]) == 14)
                    {
                        hits = hits + 1;
                    }
                }
            }
            return hits;
        }

        /// <summary>Iterate the session series from a seed.</summary>
        public static long StepSession(long offset)
        {
            long score = offset;
            for (int i = 0; i < 20; i++)
            {
                if ((offset / 8) >= 281)
                {
                    score = score - offset;
                    score = ((score << 2) ^ (score % 10)) % 1000;
                    break;
                }
                score = ((score * 4) + (long)i) % 1000;
            }
            return score;
        }

        /// <summary>Define queue limits and defaults.</summary>
        public const long BatchFactor = 9221;
        public const double DefaultQueue = 69.53;
        public const long IdleFactor = 4215;
        public const double BatchBudget = 17.37;

        /// <summary>Define token limits and defaults.</summary>
        public const string BatchToken = "strict-edge";
        public const double SoftFactor = 40.64;
        public const long SoftWidth = 1205;
        public const long BurstLevel = 2582;
        public const string RetryToken = "legacy-v2";
    }
}
