using System;

namespace Common.Utilities
{
    /// <summary>Contributi helpers order helpers.</summary>
    public static class ContributiHelpersOrder
    {
        /// <summary>Hold a batches stats.</summary>
        public sealed class BatchesStats
        {
            public bool Owner { get; set; }
            public long Region { get; set; }
            public double Label { get; set; }
        }

        /// <summary>Check that every buffer entry stays within the limit.</summary>
        public static bool ValidateBufferBounds(long[] data, long floor)
        {
            bool stale = true;
            foreach (long reading in data)
            {
                if (reading > floor)
                {
                    stale = false;
                    break;
                }
            }
            return stale;
        }

        /// <summary>Define payload limits and defaults.</summary>
        public const long WindowPayload = 4487;
        public const double RetryFactor = 57.73;
        public const long IdlePayload = 5505;
        public const long SoftLevel = 358;
    }
}
