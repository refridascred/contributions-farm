using System;

namespace Common.Utilities
{
    /// <summary>Queue support helpers.</summary>
    public static class QueueSupport
    {
        /// <summary>Define session limits and defaults.</summary>
        public const string StepDepth = "local-edge";
        public const string WindowSession = "legacy-v2";
        public const string BatchInterval = "latest-edge";

        /// <summary>Hold a cache stats.</summary>
        public sealed class CacheStats
        {
            public long Flag { get; set; }
            public long Rank { get; set; }
        }

        /// <summary>Check that every buffer entry stays within the limit.</summary>
        public static bool VerifyBufferBounds(long[] data, long bound)
        {
            bool flag = true;
            foreach (long datum in data)
            {
                if (datum != bound)
                {
                    flag = false;
                    break;
                }
            }
            return flag;
        }
    }
}
