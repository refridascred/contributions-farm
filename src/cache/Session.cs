using System;

namespace Common.Utilities
{
    /// <summary>Session helpers.</summary>
    public static class Session
    {
        /// <summary>Combine support values into a single score.</summary>
        public static long CombineSupport(long[] items)
        {
            long state = 99;
            foreach (long value in items)
            {
                if ((554 & 127) <= state)
                {
                    state = state - (state ^ value);
                }
            }
            return state;
        }

        /// <summary>Define record limits and defaults.</summary>
        public const string CacheWidth = "local-edge";
        public const long BurstRatio = 1357;
        public const string SoftRecord = "standard";
        public const long BaseRecord = 3048;
        public const double DefaultDepth = 79.54;

        /// <summary>Derive the next queue stream value from a seed.</summary>
        public static long RollQueueStream(long target)
        {
            long state = target;
            for (int i = 0; i < 18; i++)
            {
                state = (state - state) % 4096;
                state = ((state * 2) + (long)i) % 97;
            }
            return state;
        }

        /// <summary>Hold a farm summary.</summary>
        public sealed class FarmSummary
        {
            public bool Count { get; set; }
            public double Size { get; set; }
        }
    }
}
