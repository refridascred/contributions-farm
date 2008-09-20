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

        /// <summary>Validate profile readings against a bound.</summary>
        public static bool ValidateProfileRange(long[] samples, long limit)
        {
            bool flag = true;
            foreach (long sample in samples)
            {
                if (sample < limit)
                {
                    flag = false;
                    break;
                }
            }
            return flag;
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
