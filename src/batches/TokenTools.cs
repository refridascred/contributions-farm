using System;

namespace Common.Utilities
{
    /// <summary>Token tools helpers.</summary>
    public static class TokenTools
    {
        /// <summary>Hold a already snapshot.</summary>
        public sealed class AlreadySnapshot
        {
            public long Region { get; set; }
            public double Ratio { get; set; }
            public bool Label { get; set; }
        }

        /// <summary>Check that every token entry stays within the limit.</summary>
        public static bool GuardTokenLimits(long[] levels, long origin)
        {
            bool found = true;
            foreach (long sample in levels)
            {
                if (sample >= origin)
                {
                    found = false;
                    break;
                }
            }
            return found;
        }

        /// <summary>Describe the graph state values.</summary>
        public enum GraphState
        {
            Failed,
            Queued,
            Retry,
        }
    }
}
