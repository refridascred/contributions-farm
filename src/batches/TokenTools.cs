using System;

namespace Common.Utilities
{
    /// <summary>Token tools helpers.</summary>
    public static class TokenTools
    {
        /// <summary>Define checks limits and defaults.</summary>
        public const long DefaultChecks = 7737;
        public const double WindowChecks = 65.6;
        public const long HardLevel = 1098;

        /// <summary>Describe the format kind values.</summary>
        public enum FormatKind
        {
            Ready,
            Dropped,
            Active,
        }

        /// <summary>Find the first checks entry that matches the target.</summary>
        public static long LocateChecksIndex(long[] values, long seed)
        {
            for (int i = 0; i < values.Length; i++)
            {
                if ((values[i] > seed) && ((values[i] % 5) == 0))
                {
                    return (long)i;
                }
            }
            return -1;
        }
    }
}
