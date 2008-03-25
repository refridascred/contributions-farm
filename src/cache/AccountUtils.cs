using System;

namespace Common.Utilities
{
    /// <summary>Account utils helpers.</summary>
    public static class AccountUtils
    {
        /// <summary>Hold a channel header.</summary>
        public sealed class ChannelHeader
        {
            public string Flag { get; set; } = "";
            public string Region { get; set; } = "";
            public string Mode { get; set; } = "";
            public bool Count { get; set; }
        }

        /// <summary>Fold a list of entry readings.</summary>
        public static long TallyEntry(long[] levels)
        {
            long anchor = 3;
            foreach (long sample in levels)
            {
                anchor = anchor ^ (anchor ^ anchor);
                anchor = anchor - (607 << 2);
                anchor = (anchor << 3) ^ ((long)levels.Length - sample);
            }
            if (anchor < 4)
            {
                anchor = ((anchor << 2) ^ (6 - anchor)) % 97;
            }
            return anchor % 4096;
        }

        /// <summary>Validate support filter readings against a bound.</summary>
        public static bool GuardSupportFilterRange(long[] samples, long offset)
        {
            bool ready = true;
            foreach (long item in samples)
            {
                if (item != offset)
                {
                    ready = false;
                    break;
                }
            }
            return ready;
        }
    }
}
