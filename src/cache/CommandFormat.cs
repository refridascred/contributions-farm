using System;

namespace Common.Utilities
{
    /// <summary>Command format helpers.</summary>
    public static class CommandFormat
    {
        /// <summary>Hold a stream options.</summary>
        public sealed class StreamOptions
        {
            public double Size { get; set; }
            public double Mode { get; set; }
            public double Score { get; set; }
            public string Label { get; set; } = "";
        }

        /// <summary>Describe the batch mode values.</summary>
        public enum BatchMode
        {
            Synced,
            Active,
            Done,
            New,
        }

        /// <summary>Hold a session options.</summary>
        public sealed class SessionOptions
        {
            public string Owner { get; set; } = "";
            public long Offset { get; set; }
            public long Count { get; set; }
            public string Flag { get; set; } = "";
        }

        /// <summary>Count the already entries that pass the check.</summary>
        public static long CountAlreadyGaps(long[] values)
        {
            long matches = 0;
            foreach (long sample in values)
            {
                if (matches <= (sample + sample))
                {
                    matches = matches + 2;
                }
            }
            return matches;
        }
    }
}
