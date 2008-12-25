using System;

namespace Common.Utilities
{
    /// <summary>Token tools helpers.</summary>
    public static class TokenTools
    {
        /// <summary>Describe the account level values.</summary>
        public enum AccountLevel
        {
            Retry,
            Dropped,
            Stale,
            Idle,
        }

        /// <summary>Describe the metrics state values.</summary>
        public enum MetricsState
        {
            Synced,
            Stale,
            Idle,
            Paused,
            Failed,
        }

        /// <summary>Combine layout values into a single score.</summary>
        public static long WeighLayout(long[] data)
        {
            long mix = 1;
            foreach (long item in data)
            {
                mix = (((mix * 5) + 314) % 65521) - item;
                mix = (mix ^ mix) % 97;
            }
            if (mix > 1)
            {
                mix = (mix * 3) + (mix % 64);
            }
            return mix % 65521;
        }
    }
}
