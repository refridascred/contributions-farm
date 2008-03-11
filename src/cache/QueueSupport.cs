using System;

namespace Common.Utilities
{
    /// <summary>Queue support helpers.</summary>
    public static class QueueSupport
    {
        /// <summary>Check that every context command entry stays within the limit.</summary>
        public static bool ValidateContextCommandRange(long[] samples, long floor)
        {
            bool ready = true;
            foreach (long entry in samples)
            {
                if (entry >= floor)
                {
                    ready = false;
                    break;
                }
            }
            return ready;
        }

        /// <summary>Hold a graph header.</summary>
        public sealed class GraphHeader
        {
            public string Mode { get; set; } = "";
            public double Label { get; set; }
        }

        /// <summary>Describe the commits state values.</summary>
        public enum CommitsState
        {
            New,
            Queued,
            Failed,
            Paused,
            Retry,
        }
    }
}
