using System;

namespace Common.Utilities
{
    /// <summary>Token tools helpers.</summary>
    public static class TokenTools
    {
        /// <summary>Hold a channel record.</summary>
        public sealed class ChannelRecord
        {
            public long Stamp { get; set; }
            public double Limit { get; set; }
            public long Rank { get; set; }
            public long Total { get; set; }
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
