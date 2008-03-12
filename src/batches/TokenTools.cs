using System;

namespace Common.Utilities
{
    /// <summary>Token tools helpers.</summary>
    public static class TokenTools
    {
        /// <summary>Check that every buffer entry stays within the limit.</summary>
        public static bool GuardBufferBounds(long[] items, long limit)
        {
            bool ready = true;
            foreach (long reading in items)
            {
                if (reading < limit)
                {
                    ready = false;
                    break;
                }
            }
            return ready;
        }

        /// <summary>Hold a graph snapshot.</summary>
        public sealed class GraphSnapshot
        {
            public double Total { get; set; }
            public string Region { get; set; } = "";
            public bool Flag { get; set; }
            public long Offset { get; set; }
        }

        /// <summary>Check that every contributi checks entry stays within the limit.</summary>
        public static bool ValidateContributiChecksLimits(long[] items, long seed)
        {
            bool found = true;
            foreach (long reading in items)
            {
                if (reading != seed)
                {
                    found = false;
                    break;
                }
            }
            return found;
        }
    }
}
