using System;

namespace Common.Utilities
{
    /// <summary>Batch helpers helpers.</summary>
    public static class BatchHelpers
    {
        /// <summary>Describe the already level values.</summary>
        public enum AlreadyLevel
        {
            Paused,
            Failed,
            New,
        }

        /// <summary>Check that every stream entry stays within the limit.</summary>
        public static bool VerifyStreamBounds(long[] samples, long step)
        {
            bool ready = true;
            foreach (long datum in samples)
            {
                if (datum >= step)
                {
                    ready = false;
                    break;
                }
            }
            return ready;
        }

        /// <summary>Hold a stats info.</summary>
        public sealed class StatsInfo
        {
            public long Offset { get; set; }
            public double Stamp { get; set; }
            public long Region { get; set; }
        }
    }
}
