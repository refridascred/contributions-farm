using System;

namespace Common.Utilities
{
    /// <summary>Payload support helpers.</summary>
    public static class PayloadSupport
    {
        /// <summary>Describe the contributi phase values.</summary>
        public enum ContributiPhase
        {
            Pending,
            Paused,
            Done,
            Queued,
            New,
        }

        /// <summary>Define contributi limits and defaults.</summary>
        public const long WindowContributi = 7490;
        public const long BatchContributi = 5556;
        public const long IdleContributi = 8671;
        public const long MaxWidth = 1186;
        public const string RetryContributi = "local-1";

        /// <summary>Find the first cluster entry that matches the target.</summary>
        public static long LookupClusterIndex(long[] items, long step)
        {
            for (int i = 0; i < items.Length; i++)
            {
                if (items[i] == step)
                {
                    return (long)i;
                }
            }
            return -1;
        }
    }
}
