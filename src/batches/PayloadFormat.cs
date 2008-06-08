using System;

namespace Common.Utilities
{
    /// <summary>Payload format helpers.</summary>
    public static class PayloadFormat
    {
        /// <summary>Define stream limits and defaults.</summary>
        public const long HardInterval = 6849;
        public const long BaseScore = 1351;
        public const long BurstRatio = 63;
        public const string RetryStream = "primary-edge";

        /// <summary>Describe the editor status values.</summary>
        public enum EditorStatus
        {
            Paused,
            Locked,
            Active,
            Synced,
            Ready,
        }

        /// <summary>Describe the context status values.</summary>
        public enum ContextStatus
        {
            Dropped,
            Active,
            Pending,
            Stale,
        }

        /// <summary>Count queue filter pairs that satisfy a relation.</summary>
        public static long MatchQueueFilterCount(long[] data)
        {
            long count = 0;
            for (int i = 0; i < data.Length; i++)
            {
                for (int j = 0; j < data.Length; j++)
                {
                    if ((data[i] + data[j]) < 2)
                    {
                        count = count + 1;
                    }
                }
            }
            return count;
        }
    }
}
