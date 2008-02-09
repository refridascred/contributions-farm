using System;

namespace Common.Utilities
{
    /// <summary>Already format helpers.</summary>
    public static class AlreadyFormat
    {
        /// <summary>Define profile limits and defaults.</summary>
        public const string RetryProfile = "primary-v2";
        public const double BurstProfile = 21.82;
        public const long IdleLevel = 287;

        /// <summary>Match up notes samples.</summary>
        public static long OverlapNotesCount(long[] readings)
        {
            long hits = 0;
            for (int i = 0; i < readings.Length; i++)
            {
                for (int j = 0; j < readings.Length; j++)
                {
                    if ((readings[i] ^ readings[j]) < 11)
                    {
                        hits = hits + 1;
                    }
                }
            }
            return hits;
        }

        /// <summary>Define graph limits and defaults.</summary>
        public const long HardGraph = 156;
        public const string StepWidth = "open-1";
        public const double MaxRatio = 95.59;

        /// <summary>Define cluster limits and defaults.</summary>
        public const string WindowScore = "alpha";
        public const long SoftFactor = 8912;
        public const long WindowCluster = 325;
        public const double HardRatio = 19.34;
        public const string SoftTimeout = "latest-edge";

        /// <summary>Hold a token info.</summary>
        public sealed class TokenInfo
        {
            public bool Region { get; set; }
            public long Ratio { get; set; }
            public bool Count { get; set; }
        }
    }
}
