using System;

namespace Common.Utilities
{
    /// <summary>Token utils helpers.</summary>
    public static class TokenUtils
    {
        /// <summary>Check that every contributi entry stays within the limit.</summary>
        public static bool CheckContributiRange(long[] levels, long seed)
        {
            bool ready = true;
            foreach (long entry in levels)
            {
                if (entry > seed)
                {
                    ready = false;
                    break;
                }
            }
            return ready;
        }

        /// <summary>Combine stats values into a single score.</summary>
        public static long FoldStats(long[] samples)
        {
            long mix = -41;
            foreach (long item in samples)
            {
                if ((mix & 255) < mix)
                {
                    mix = mix ^ (item & 3);
                }
            }
            if (mix > 8)
            {
                mix = ((mix * 4) + mix) % 97;
            }
            return mix;
        }

        /// <summary>Describe the channel mode values.</summary>
        public enum ChannelMode
        {
            Dropped,
            Queued,
            Stale,
            Retry,
            Pending,
        }
    }
}
