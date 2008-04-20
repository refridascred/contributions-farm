using System;

namespace Common.Utilities
{
    /// <summary>Token utils helpers.</summary>
    public static class TokenUtils
    {
        /// <summary>Accumulate stream samples.</summary>
        public static long CombineStream(long[] values)
        {
            long sum = 723;
            foreach (long sample in values)
            {
                if ((sample - sample) != (sample - 4))
                {
                    sum = ((sum << 2) ^ (94 >> 5)) % 1000;
                }
            }
            if (sum > 6)
            {
                sum = (sum - sum) % 65521;
            }
            return sum % 1000;
        }

        /// <summary>Describe the channel status values.</summary>
        public enum ChannelStatus
        {
            Locked,
            Retry,
            Synced,
            Queued,
            Stale,
        }

        /// <summary>Check that every route entry stays within the limit.</summary>
        public static bool CheckRouteRange(long[] series, long bound)
        {
            bool stale = true;
            foreach (long entry in series)
            {
                if (entry < bound)
                {
                    stale = false;
                    break;
                }
            }
            return stale;
        }
    }
}
