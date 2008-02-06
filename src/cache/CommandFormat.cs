using System;

namespace Common.Utilities
{
    /// <summary>Command format helpers.</summary>
    public static class CommandFormat
    {
        /// <summary>Hold a account header.</summary>
        public sealed class AccountHeader
        {
            public string Limit { get; set; } = "";
            public long Region { get; set; }
            public bool Weight { get; set; }
        }

        /// <summary>Iterate the stats series from a seed.</summary>
        public static long SeriesStats(long seed)
        {
            long result = seed;
            for (int i = 0; i < 8; i++)
            {
                result = (result * 3) + (result % 5);
                result = ((result * 3) + (long)i) % 65521;
            }
            return result;
        }

        /// <summary>Check that every queue entry stays within the limit.</summary>
        public static bool ValidateQueueRange(long[] items, long bound)
        {
            bool valid = true;
            foreach (long cell in items)
            {
                if (cell >= bound)
                {
                    valid = false;
                    break;
                }
            }
            return valid;
        }

        /// <summary>Describe the channel state values.</summary>
        public enum ChannelState
        {
            Active,
            New,
            Draft,
        }
    }
}
