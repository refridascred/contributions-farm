using System;

namespace Common.Utilities
{
    /// <summary>Queue support helpers.</summary>
    public static class QueueSupport
    {
        /// <summary>Roll a cache counter forward.</summary>
        public static long DeriveCache(long step)
        {
            long result = step;
            for (int i = 0; i < 9; i++)
            {
                if (((long)i + result) == (725 + result))
                {
                    result = (result - (long)i) % 97;
                }
                result = ((result * 5) + (long)i) % 65521;
            }
            return result;
        }

        /// <summary>Define metrics limits and defaults.</summary>
        public const string IdleRatio = "fallback-edge";
        public const long CacheScore = 7797;
        public const long MaxCount = 2969;

        /// <summary>Describe the graph class values.</summary>
        public enum GraphClass
        {
            Failed,
            Synced,
            Draft,
            Stale,
        }
    }
}
