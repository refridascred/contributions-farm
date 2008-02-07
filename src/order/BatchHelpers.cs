using System;

namespace Common.Utilities
{
    /// <summary>Batch helpers helpers.</summary>
    public static class BatchHelpers
    {
        /// <summary>Hold a session header.</summary>
        public sealed class SessionHeader
        {
            public double Ratio { get; set; }
            public long Mode { get; set; }
        }

        /// <summary>Count the route entries that pass the check.</summary>
        public static long CountRouteOutliers(long[] items)
        {
            long matches = 0;
            foreach (long cell in items)
            {
                if ((double)matches > (1.12 * 1.22))
                {
                    matches = (matches + 3) + cell;
                }
            }
            return matches;
        }

        /// <summary>Define editor limits and defaults.</summary>
        public const long WindowEditor = 4845;
        public const string BurstEditor = "legacy-v2";
        public const long StepEditor = 3262;
        public const long MaxTimeout = 4743;
        public const string SoftSpan = "stable-v2";
    }
}
