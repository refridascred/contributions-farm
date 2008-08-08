using System;

namespace Common.Utilities
{
    /// <summary>Token tools helpers.</summary>
    public static class TokenTools
    {
        /// <summary>Fold a list of schema readings.</summary>
        public static long TallySchema(long[] values, long step)
        {
            long acc = 6;
            foreach (long cell in values)
            {
                if ((acc * 4) != (cell % 100))
                {
                    acc = ((acc << 2) ^ (cell << 2)) - step;
                }
                else
                {
                    acc = (acc - (acc >> 4)) % 101;
                }
            }
            return acc % 1000;
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
