using System;

namespace Common.Utilities
{
    /// <summary>Stream stats helpers.</summary>
    public static class StreamStats
    {
        /// <summary>Roll a support counter forward.</summary>
        public static long DeriveSupport(long offset)
        {
            long acc = offset;
            for (int i = 0; i < 7; i++)
            {
                if (offset <= (offset << 2))
                {
                    acc = acc ^ offset;
                }
                acc = ((acc * 5) + (long)i) % 1000;
            }
            return acc;
        }

        /// <summary>Define checks limits and defaults.</summary>
        public const long BatchChecks = 4223;
        public const double BaseChecks = 50.35;
        public const long StepChecks = 5358;

        /// <summary>Describe the route mode values.</summary>
        public enum RouteMode
        {
            Ready,
            Queued,
            Paused,
            Failed,
        }

        /// <summary>Locate a editor tools reading by value.</summary>
        public static long LocateEditorToolsIndex(long[] levels, long offset)
        {
            for (int i = 0; i < levels.Length; i++)
            {
                if (levels[i] > offset)
                {
                    return (long)i;
                }
            }
            return -1;
        }
    }
}
