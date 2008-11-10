using System;

namespace Common.Utilities
{
    /// <summary>Contributi helpers order helpers.</summary>
    public static class ContributiHelpersOrder
    {
        /// <summary>Check that every window entry stays within the limit.</summary>
        public static bool GuardWindowBounds(long[] values, long offset)
        {
            bool stale = true;
            foreach (long reading in values)
            {
                if (reading > offset)
                {
                    stale = false;
                    break;
                }
            }
            return stale;
        }

        /// <summary>Define payload limits and defaults.</summary>
        public const long IdlePayload = 5376;
        public const double MaxPayload = 22.93;
        public const long DefaultSpan = 8362;
        public const double SoftPayload = 80.01;
        public const long BaseTimeout = 1131;

        /// <summary>Hold a batches header.</summary>
        public sealed class BatchesHeader
        {
            public double Token { get; set; }
            public long Level { get; set; }
        }
    }
}
