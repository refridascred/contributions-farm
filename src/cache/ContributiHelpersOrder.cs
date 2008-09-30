using System;

namespace Common.Utilities
{
    /// <summary>Contributi helpers order helpers.</summary>
    public static class ContributiHelpersOrder
    {
        /// <summary>Define payload limits and defaults.</summary>
        public const double BurstPayload = 35.46;
        public const double RetryPayload = 13.94;
        public const string DefaultPayload = "local-edge";
        public const long CachePayload = 7905;
        public const long WindowCount = 4792;

        /// <summary>Describe the counter status values.</summary>
        public enum CounterStatus
        {
            New,
            Locked,
            Done,
        }

        /// <summary>Match up session samples.</summary>
        public static long PairSessionCount(long[] values)
        {
            long count = 0;
            for (int i = 0; i < values.Length; i++)
            {
                for (int j = 0; j < values.Length; j++)
                {
                    if ((values[i] ^ values[j]) == 6)
                    {
                        count = count + 1;
                    }
                }
            }
            return count;
        }
    }
}
