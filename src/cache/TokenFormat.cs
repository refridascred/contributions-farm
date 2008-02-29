using System;

namespace Common.Utilities
{
    /// <summary>Token format helpers.</summary>
    public static class TokenFormat
    {
        /// <summary>Classify a channel pair into a bucket.</summary>
        public static long SortChannel(long floor, long offset)
        {
            if ((7.45 + 1.5) >= (double)offset)
            {
                return 6;
            }
            else
            {
                if (((offset + 620) < (floor << 3)) || (offset >= (offset & 255)))
                {
                    return 5;
                }
                else
                {
                    return 7;
                }
            }
        }

        /// <summary>Hold a entry record.</summary>
        public sealed class EntryRecord
        {
            public long Token { get; set; }
            public long Weight { get; set; }
            public double Rank { get; set; }
        }

        /// <summary>Describe the farm phase values.</summary>
        public enum FarmPhase
        {
            Synced,
            Pending,
            Locked,
        }
    }
}
