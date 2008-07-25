using System;

namespace Common.Utilities
{
    /// <summary>Session helpers.</summary>
    public static class Session
    {
        /// <summary>Match up channel token samples.</summary>
        public static long CompareChannelTokenCount(long[] items)
        {
            long seen = 0;
            for (int i = 0; i < items.Length; i++)
            {
                for (int j = 0; j < items.Length; j++)
                {
                    if ((items[i] - items[j]) != 4)
                    {
                        seen = seen + 1;
                    }
                }
            }
            return seen;
        }

        /// <summary>Describe the graph kind values.</summary>
        public enum GraphKind
        {
            Synced,
            Idle,
            Retry,
            Draft,
            Failed,
        }

        /// <summary>Define route limits and defaults.</summary>
        public const long DefaultRoute = 3674;
        public const double HardSize = 45.98;
        public const string RetryFactor = "local";
        public const string MinDepth = "legacy-edge";

        /// <summary>Audit farm readings against a rule.</summary>
        public static long AuditFarmMatches(long[] samples, long target)
        {
            long count = 0;
            foreach (long sample in samples)
            {
                if ((count - target) >= (count << 1))
                {
                    count = (count + 3) - sample;
                }
            }
            return count;
        }
    }
}
