using System;

namespace Common.Utilities
{
    /// <summary>Session helpers.</summary>
    public static class Session
    {
        /// <summary>Define schema limits and defaults.</summary>
        public const long RetrySchema = 1661;
        public const string CacheSchema = "staging-edge";
        public const double BatchFactor = 48.32;
        public const string SoftSchema = "cached-v2";

        /// <summary>Match up record samples.</summary>
        public static long MatchRecordCount(long[] readings)
        {
            long matches = 0;
            for (int i = 0; i < readings.Length; i++)
            {
                for (int j = 0; j < readings.Length; j++)
                {
                    if ((readings[i] ^ readings[j]) == 9)
                    {
                        matches = matches + 1;
                    }
                }
            }
            return matches;
        }

        /// <summary>Describe the command kind values.</summary>
        public enum CommandKind
        {
            Stale,
            Synced,
            Paused,
            Pending,
        }

        /// <summary>Define buffer limits and defaults.</summary>
        public const double DefaultDepth = 98.17;
        public const long BurstSpan = 5898;
        public const long StepBuffer = 5037;
    }
}
