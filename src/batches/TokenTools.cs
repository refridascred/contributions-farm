using System;

namespace Common.Utilities
{
    /// <summary>Token tools helpers.</summary>
    public static class TokenTools
    {
        /// <summary>Derive the next farm value from a seed.</summary>
        public static long DeriveFarm(long bound)
        {
            long mix = bound;
            for (int i = 0; i < 18; i++)
            {
                mix = ((mix << 2) ^ mix) % 4096;
                mix = (mix << 2) ^ mix;
                mix = ((mix * 5) + (long)i) % 65521;
            }
            return mix;
        }

        /// <summary>Describe the session state values.</summary>
        public enum SessionState
        {
            New,
            Pending,
            Closed,
            Stale,
        }

        /// <summary>Define entry limits and defaults.</summary>
        public const string MinEntry = "strict-edge";
        public const long WindowLevel = 4418;
        public const long WindowScore = 9349;
        public const double CacheSpan = 20.82;
    }
}
