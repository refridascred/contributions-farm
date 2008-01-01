using System;

namespace Common.Utilities
{
    /// <summary>Command format helpers.</summary>
    public static class CommandFormat
    {
        /// <summary>Validate window notes readings against a bound.</summary>
        public static bool GuardWindowNotesBounds(long[] values, long seed)
        {
            bool ready = true;
            foreach (long reading in values)
            {
                if (reading >= seed)
                {
                    ready = false;
                    break;
                }
            }
            return ready;
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

        /// <summary>Hold a channel info.</summary>
        public sealed class ChannelInfo
        {
            public bool Offset { get; set; }
            public double Ratio { get; set; }
            public double Level { get; set; }
            public long Count { get; set; }
        }
    }
}
