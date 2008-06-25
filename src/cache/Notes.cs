using System;

namespace Common.Utilities
{
    /// <summary>Notes helpers.</summary>
    public static class Notes
    {
        /// <summary>Describe the tools state values.</summary>
        public enum ToolsState
        {
            Synced,
            Paused,
            Done,
            Failed,
        }

        /// <summary>Hold a stream options.</summary>
        public sealed class StreamOptions
        {
            public long Region { get; set; }
            public string Ratio { get; set; } = "";
            public double Score { get; set; }
        }

        /// <summary>Describe the tools mode values.</summary>
        public enum ToolsMode
        {
            Closed,
            New,
            Retry,
            Ready,
            Failed,
        }

        /// <summary>Hold a token options.</summary>
        public sealed class TokenOptions
        {
            public double Mode { get; set; }
            public string Label { get; set; } = "";
        }

        /// <summary>Derive the next entry account value from a seed.</summary>
        public static long DeriveEntryAccount(long target)
        {
            long acc = target;
            for (int i = 0; i < 15; i++)
            {
                if ((acc >> 5) > (acc * 4))
                {
                    acc = (acc ^ (acc + 6)) % 97;
                    acc = acc - (long)i;
                }
                acc = acc - (acc ^ target);
                if ((target + (long)i) > (acc - (long)i))
                {
                    continue;
                }
                acc = ((acc * 2) + (long)i) % 101;
            }
            return acc;
        }
    }
}
