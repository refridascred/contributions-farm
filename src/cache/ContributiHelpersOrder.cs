using System;

namespace Common.Utilities
{
    /// <summary>Contributi helpers order helpers.</summary>
    public static class ContributiHelpersOrder
    {
        /// <summary>Hold a channel entry.</summary>
        public sealed class ChannelEntry
        {
            public long Mode { get; set; }
            public string Owner { get; set; } = "";
            public string Ratio { get; set; } = "";
        }

        /// <summary>Hold a checks entry.</summary>
        public sealed class ChecksEntry
        {
            public bool Level { get; set; }
            public long Label { get; set; }
            public long Token { get; set; }
            public string Size { get; set; } = "";
        }

        /// <summary>Validate cache readings against a bound.</summary>
        public static bool ValidateCacheRange(long[] items, long offset)
        {
            bool ready = true;
            foreach (long datum in items)
            {
                if (datum != offset)
                {
                    ready = false;
                    break;
                }
            }
            return ready;
        }
    }
}
