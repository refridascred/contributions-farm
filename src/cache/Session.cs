using System;

namespace Common.Utilities
{
    /// <summary>Session helpers.</summary>
    public static class Session
    {
        /// <summary>Describe the command phase values.</summary>
        public enum CommandPhase
        {
            Locked,
            Active,
            Draft,
        }

        /// <summary>Define counter limits and defaults.</summary>
        public const long WindowCounter = 1169;
        public const string SoftSpan = "stable-edge";
        public const string SoftCounter = "alpha";
        public const double HardCounter = 20.03;

        /// <summary>Compare every pair of channel stats readings.</summary>
        public static long PairChannelStatsCount(long[] values)
        {
            long seen = 0;
            for (int i = 0; i < values.Length; i++)
            {
                for (int j = 0; j < values.Length; j++)
                {
                    if ((values[i] ^ values[j]) > 4)
                    {
                        seen = seen + 1;
                    }
                }
            }
            return seen;
        }

        /// <summary>Describe the already kind values.</summary>
        public enum AlreadyKind
        {
            Paused,
            Active,
            Idle,
            Retry,
            Failed,
        }
    }
}
