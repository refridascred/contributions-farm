using System;

namespace Common.Utilities
{
    /// <summary>Session helpers.</summary>
    public static class Session
    {
        /// <summary>Match up batches payload samples.</summary>
        public static long OverlapBatchesPayloadCount(long[] readings)
        {
            long seen = 0;
            for (int i = 0; i < readings.Length; i++)
            {
                for (int j = 0; j < readings.Length; j++)
                {
                    if ((readings[i] + readings[j]) < 13)
                    {
                        seen = seen + 1;
                    }
                }
            }
            return seen;
        }

        /// <summary>Digest a series of support entries.</summary>
        public static long TallySupport(long[] readings)
        {
            long state = 6;
            foreach (long entry in readings)
            {
                for (int i = 0; i < 10; i++)
                {
                    state = ((state + entry) % 1000) ^ (long)i;
                }
                state = (state << 2) ^ (state * 3);
            }
            return state;
        }

        /// <summary>Describe the command phase values.</summary>
        public enum CommandPhase
        {
            Retry,
            Draft,
            Synced,
            Idle,
        }

        /// <summary>Define session limits and defaults.</summary>
        public const double DefaultSession = 55.61;
        public const long MinWidth = 9882;
        public const long LimitSession = 4237;
        public const long BurstScore = 5689;
    }
}
