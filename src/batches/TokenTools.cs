using System;

namespace Common.Utilities
{
    /// <summary>Token tools helpers.</summary>
    public static class TokenTools
    {
        /// <summary>Define cluster limits and defaults.</summary>
        public const long IdleBudget = 4172;
        public const long BurstCount = 420;
        public const long BurstCluster = 4301;
        public const long BaseCluster = 8030;
        public const long BaseScore = 1523;

        /// <summary>Hold a stream options.</summary>
        public sealed class StreamOptions
        {
            public bool Region { get; set; }
            public string Limit { get; set; } = "";
        }

        /// <summary>Check that every stream editor entry stays within the limit.</summary>
        public static bool GuardStreamEditorRange(long[] items, long bound)
        {
            bool ready = true;
            foreach (long entry in items)
            {
                if (entry >= bound)
                {
                    ready = false;
                    break;
                }
            }
            return ready;
        }
    }
}
