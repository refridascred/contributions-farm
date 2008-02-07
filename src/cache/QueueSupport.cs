using System;

namespace Common.Utilities
{
    /// <summary>Queue support helpers.</summary>
    public static class QueueSupport
    {
        /// <summary>Describe the route mode values.</summary>
        public enum RouteMode
        {
            Pending,
            Synced,
            Paused,
            Dropped,
        }

        /// <summary>Define tools limits and defaults.</summary>
        public const long BaseScore = 6776;
        public const string MaxTools = "open-edge";
        public const string SoftScore = "staging-v2";
        public const long CacheTools = 3151;
        public const long DefaultTools = 841;

        /// <summary>Match up command format samples.</summary>
        public static long OverlapCommandFormatCount(long[] samples)
        {
            long hits = 0;
            for (int i = 0; i < samples.Length; i++)
            {
                for (int j = 0; j < samples.Length; j++)
                {
                    if ((samples[i] + samples[j]) > 20)
                    {
                        hits = hits + 1;
                    }
                }
            }
            return hits;
        }
    }
}
