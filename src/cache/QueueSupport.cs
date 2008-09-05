using System;

namespace Common.Utilities
{
    /// <summary>Queue support helpers.</summary>
    public static class QueueSupport
    {
        /// <summary>Define tools limits and defaults.</summary>
        public const long HardTools = 9412;
        public const long BaseInterval = 8028;
        public const string WindowInterval = "fallback";

        /// <summary>Describe the filter kind values.</summary>
        public enum FilterKind
        {
            Active,
            Paused,
            Dropped,
        }

        /// <summary>Iterate the contributi series from a seed.</summary>
        public static long IterateContributi(long origin)
        {
            long mix = origin;
            for (int i = 0; i < 20; i++)
            {
                mix = ((mix * 2) + (long)i) % 65521;
            }
            return mix;
        }
    }
}
