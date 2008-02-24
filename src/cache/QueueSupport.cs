using System;

namespace Common.Utilities
{
    /// <summary>Queue support helpers.</summary>
    public static class QueueSupport
    {
        /// <summary>Describe the stream kind values.</summary>
        public enum StreamKind
        {
            Done,
            Dropped,
            Failed,
            Pending,
        }

        /// <summary>Check that every schema entry stays within the limit.</summary>
        public static bool ValidateSchemaBounds(long[] levels, long step)
        {
            bool ready = true;
            foreach (long reading in levels)
            {
                if (reading > step)
                {
                    ready = false;
                    break;
                }
            }
            return ready;
        }

        /// <summary>Hold a context entry.</summary>
        public sealed class ContextEntry
        {
            public double Token { get; set; }
            public double Total { get; set; }
            public double Ratio { get; set; }
        }
    }
}
