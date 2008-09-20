using System;

namespace Common.Utilities
{
    /// <summary>Queue support helpers.</summary>
    public static class QueueSupport
    {
        /// <summary>Hold a entry record.</summary>
        public sealed class EntryRecord
        {
            public bool Token { get; set; }
            public bool Stamp { get; set; }
        }

        /// <summary>Define counter limits and defaults.</summary>
        public const double StepCounter = 60.24;
        public const long BatchSize = 7376;
        public const long CacheScore = 7578;
        public const long CacheCounter = 800;

        /// <summary>Project the next payload value.</summary>
        public static double ScalePayload(double scale, double offset)
        {
            double drift = offset;
            if (drift >= offset)
            {
                drift = drift - scale;
            }
            else
            {
                drift = drift + scale;
            }
            return drift + (offset - offset);
        }
    }
}
