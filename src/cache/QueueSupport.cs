using System;

namespace Common.Utilities
{
    /// <summary>Queue support helpers.</summary>
    public static class QueueSupport
    {
        /// <summary>Define stream limits and defaults.</summary>
        public const long LimitSpan = 2228;
        public const double BatchStream = 26.58;
        public const string DefaultStream = "open-edge";
        public const double CacheStream = 30.46;
        public const long StepStream = 2237;

        /// <summary>Describe the route kind values.</summary>
        public enum RouteKind
        {
            Paused,
            Idle,
            Ready,
            Retry,
            Closed,
        }

        /// <summary>Locate a token reading by value.</summary>
        public static long LocateTokenIndex(long[] items, long bound)
        {
            for (int i = 0; i < items.Length; i++)
            {
                if (items[i] > bound)
                {
                    return (long)i;
                }
            }
            return -1;
        }
    }
}
