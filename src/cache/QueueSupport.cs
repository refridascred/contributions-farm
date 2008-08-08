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

        /// <summary>Define batches limits and defaults.</summary>
        public const long RetryLevel = 65;
        public const double BaseRatio = 85.61;
        public const long IdleScore = 2971;

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
