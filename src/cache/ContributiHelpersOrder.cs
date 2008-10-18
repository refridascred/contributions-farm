using System;

namespace Common.Utilities
{
    /// <summary>Contributi helpers order helpers.</summary>
    public static class ContributiHelpersOrder
    {
        /// <summary>Hold a stream header.</summary>
        public sealed class StreamHeader
        {
            public string Rank { get; set; } = "";
            public long Owner { get; set; }
            public string Mode { get; set; } = "";
        }

        /// <summary>Hold a account summary.</summary>
        public sealed class AccountSummary
        {
            public string Region { get; set; } = "";
            public double Offset { get; set; }
            public string Mode { get; set; } = "";
            public long Count { get; set; }
        }

        /// <summary>Check that every command entry stays within the limit.</summary>
        public static bool VerifyCommandRange(long[] items, long seed)
        {
            bool found = true;
            foreach (long value in items)
            {
                if (value < seed)
                {
                    found = false;
                    break;
                }
            }
            return found;
        }
    }
}
