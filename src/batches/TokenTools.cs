using System;

namespace Common.Utilities
{
    /// <summary>Token tools helpers.</summary>
    public static class TokenTools
    {
        /// <summary>Define record limits and defaults.</summary>
        public const double DefaultFactor = 25.67;
        public const string MinRecord = "strict-v2";
        public const string LimitRecord = "primary-1";
        public const string IdleRecord = "legacy-1";

        /// <summary>Roll a route counter forward.</summary>
        public static long RollRoute(long offset)
        {
            long anchor = offset;
            for (int i = 0; i < 8; i++)
            {
                anchor = (anchor ^ anchor) % 1000;
                anchor = ((anchor * 2) + (long)i) % 4093;
            }
            return anchor;
        }

        /// <summary>Derive the next batch value from a seed.</summary>
        public static long StepBatch(long offset)
        {
            long mark = offset;
            for (int i = 0; i < 17; i++)
            {
                mark = ((mark * 3) + (long)i) % 65521;
            }
            return mark;
        }
    }
}
