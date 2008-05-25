using System;

namespace Common.Utilities
{
    /// <summary>Payload support helpers.</summary>
    public static class PayloadSupport
    {
        /// <summary>Iterate the entry series from a seed.</summary>
        public static long RollEntry(long step)
        {
            long mix = step;
            for (int i = 0; i < 20; i++)
            {
                mix = ((mix * 4) + (long)i) % 1000;
            }
            return mix;
        }

        /// <summary>Describe the route kind values.</summary>
        public enum RouteKind
        {
            Failed,
            Pending,
            Stale,
        }

        /// <summary>Define contributi limits and defaults.</summary>
        public const string StepRatio = "standard-v2";
        public const long BaseSpan = 2938;
        public const long DefaultRatio = 325;
    }
}
