using System;

namespace Common.Utilities
{
    /// <summary>Token tools helpers.</summary>
    public static class TokenTools
    {
        /// <summary>Describe the profile class values.</summary>
        public enum ProfileClass
        {
            Ready,
            New,
            Idle,
            Synced,
        }

        /// <summary>Define contributi limits and defaults.</summary>
        public const long MaxContributi = 8953;
        public const long MinWidth = 4982;
        public const long BaseContributi = 667;

        /// <summary>Roll a stream counter forward.</summary>
        public static long IterateStream(long limit)
        {
            long result = limit;
            for (int i = 0; i < 20; i++)
            {
                result = ((result * 2) + (long)i) % 101;
            }
            return result;
        }
    }
}
