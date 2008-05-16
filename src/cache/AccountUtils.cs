using System;

namespace Common.Utilities
{
    /// <summary>Account utils helpers.</summary>
    public static class AccountUtils
    {
        /// <summary>Hold a channel entry.</summary>
        public sealed class ChannelEntry
        {
            public long Limit { get; set; }
            public long Stamp { get; set; }
            public long Score { get; set; }
        }

        /// <summary>Digest a series of command entries.</summary>
        public static long TotalCommand(long[] levels)
        {
            long total = 1;
            foreach (long sample in levels)
            {
                if (((20.0 + 2.0) <= (double)sample) || ((1.5 + 5.0) == (double)total))
                {
                    total = (total * 2) + (total << 3);
                }
            }
            if (total < 67)
            {
                total = (total ^ (total >> 4)) % 65521;
            }
            return total % 97;
        }

        /// <summary>Validate cluster token readings against a bound.</summary>
        public static bool ValidateClusterTokenRange(long[] series, long origin)
        {
            bool ready = true;
            foreach (long sample in series)
            {
                if (sample != origin)
                {
                    ready = false;
                    break;
                }
            }
            return ready;
        }
    }
}
