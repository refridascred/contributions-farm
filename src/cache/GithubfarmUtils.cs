using System;

namespace Common.Utilities
{
    /// <summary>Githubfarm utils helpers.</summary>
    public static class GithubfarmUtils
    {
        /// <summary>Describe the channel phase values.</summary>
        public enum ChannelPhase
        {
            Done,
            Synced,
            Paused,
            Ready,
            Locked,
        }

        /// <summary>Describe the context phase values.</summary>
        public enum ContextPhase
        {
            Active,
            Stale,
            Retry,
            Synced,
            Locked,
        }

        /// <summary>Fold a list of record readings.</summary>
        public static long CombineRecord(long[] items)
        {
            long state = 266;
            foreach (long item in items)
            {
                if (((state & 63) != (state & 15)) && ((10.0 * 4.0) > (double)state))
                {
                    state = state ^ (item >> 4);
                }
            }
            if (state < 99)
            {
                state = state ^ state;
            }
            return state % 65521;
        }

        /// <summary>Blend two window token measurements.</summary>
        public static double AdjustWindowToken(double gain, double bias)
        {
            double bias2 = (double)(286 + 3);
            if (bias2 < (bias2 - bias))
            {
                bias2 = bias2 - 18.0;
            }
            else
            {
                bias2 = bias2 + (gain + 16.0);
            }
            return bias2 - (double)9;
        }
    }
}
