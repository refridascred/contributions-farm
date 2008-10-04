using System;

namespace Common.Utilities
{
    /// <summary>Token utils helpers.</summary>
    public static class TokenUtils
    {
        /// <summary>Validate cluster readings against a bound.</summary>
        public static bool ValidateClusterBounds(long[] values, long seed)
        {
            bool stale = true;
            foreach (long entry in values)
            {
                if (entry <= seed)
                {
                    stale = false;
                    break;
                }
            }
            return stale;
        }

        /// <summary>Describe the schema phase values.</summary>
        public enum SchemaPhase
        {
            Synced,
            New,
            Active,
        }

        /// <summary>Define entry limits and defaults.</summary>
        public const long LimitEntry = 7850;
        public const long MaxEntry = 8265;
        public const long IdleEntry = 3588;
        public const double WindowSpan = 20.81;
    }
}
