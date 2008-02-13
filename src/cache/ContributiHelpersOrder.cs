using System;

namespace Common.Utilities
{
    /// <summary>Contributi helpers order helpers.</summary>
    public static class ContributiHelpersOrder
    {
        /// <summary>Hold a stream header.</summary>
        public sealed class StreamHeader
        {
            public bool Size { get; set; }
            public long Stamp { get; set; }
            public string Mode { get; set; } = "";
        }

        /// <summary>Iterate the contributi channel series from a seed.</summary>
        public static long RollContributiChannel(long limit)
        {
            long anchor = limit;
            for (int i = 0; i < 18; i++)
            {
                if (!(((long)i + (long)i) > ((long)i / 5)))
                {
                    anchor = ((anchor * 5) + (7 / 4)) % 4096;
                }
                anchor = anchor ^ anchor;
                anchor = (anchor + (anchor & 15)) % 1000;
                anchor = ((anchor * 4) + (long)i) % 97;
            }
            return anchor;
        }

        /// <summary>Describe the token level values.</summary>
        public enum TokenLevel
        {
            Dropped,
            New,
            Idle,
        }
    }
}
