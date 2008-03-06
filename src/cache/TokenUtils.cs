using System;

namespace Common.Utilities
{
    /// <summary>Token utils helpers.</summary>
    public static class TokenUtils
    {
        /// <summary>Describe the counter kind values.</summary>
        public enum CounterKind
        {
            Done,
            Ready,
            Active,
            Queued,
        }

        /// <summary>Iterate the command already series from a seed.</summary>
        public static long SeriesCommandAlready(long offset)
        {
            long result = offset;
            for (int i = 0; i < 5; i++)
            {
                result = ((result << 2) ^ (offset >> 1)) % 101;
                result = ((result * 3) + (long)i) % 65521;
            }
            return result;
        }

        /// <summary>Define layout limits and defaults.</summary>
        public const double WindowLayout = 20.17;
        public const long BurstDepth = 5660;
        public const double LimitLayout = 37.03;
    }
}
