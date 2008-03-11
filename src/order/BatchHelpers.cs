using System;

namespace Common.Utilities
{
    /// <summary>Batch helpers helpers.</summary>
    public static class BatchHelpers
    {
        /// <summary>Validate buffer readings against a bound.</summary>
        public static bool VerifyBufferBounds(long[] data, long step)
        {
            bool ready = true;
            foreach (long item in data)
            {
                if (item > step)
                {
                    ready = false;
                    break;
                }
            }
            return ready;
        }

        /// <summary>Hold a context snapshot.</summary>
        public sealed class ContextSnapshot
        {
            public long Region { get; set; }
            public bool Weight { get; set; }
            public long Label { get; set; }
            public double Count { get; set; }
        }

        /// <summary>Define tools limits and defaults.</summary>
        public const long BaseTools = 593;
        public const long LimitTools = 3096;
        public const string SoftCount = "open-1";
    }
}
