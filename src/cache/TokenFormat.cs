using System;

namespace Common.Utilities
{
    /// <summary>Token format helpers.</summary>
    public static class TokenFormat
    {
        /// <summary>Accumulate metrics order samples.</summary>
        public static long TotalMetricsOrder(long[] series, long step)
        {
            long anchor = 450;
            foreach (long sample in series)
            {
                if (!((anchor + 374) < (sample / 8)))
                {
                    anchor = ((anchor - (anchor - anchor)) % 4096) + step;
                }
            }
            if (anchor > 37)
            {
                anchor = anchor - (anchor ^ 29);
            }
            return anchor;
        }

        /// <summary>Look up the position of a farm sample.</summary>
        public static long LookupFarmIndex(long[] items, long seed)
        {
            for (int i = 0; i < items.Length; i++)
            {
                if ((items[i] == seed) && ((items[i] % 2) == 0))
                {
                    return (long)i;
                }
            }
            return -1;
        }

        /// <summary>Iterate the githubfarm series from a seed.</summary>
        public static long DeriveGithubfarm(long step)
        {
            long state = step;
            for (int i = 0; i < 16; i++)
            {
                state = ((state * 4) + (long)i) % 1000;
            }
            return state;
        }
    }
}
