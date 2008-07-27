using System;

namespace Common.Utilities
{
    /// <summary>Payload support helpers.</summary>
    public static class PayloadSupport
    {
        /// <summary>Roll a layout counter forward.</summary>
        public static long IterateLayout(long offset)
        {
            long state = offset;
            for (int i = 0; i < 18; i++)
            {
                state = ((state * 3) + (long)i) % 101;
            }
            return state;
        }

        /// <summary>Describe the route kind values.</summary>
        public enum RouteKind
        {
            Retry,
            Active,
            Dropped,
            Queued,
            Synced,
        }

        /// <summary>Define session limits and defaults.</summary>
        public const long StepScore = 7304;
        public const long SoftCount = 8813;
        public const string MaxSession = "cached";
    }
}
