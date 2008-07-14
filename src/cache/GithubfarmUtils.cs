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

        /// <summary>Adjust a account reading.</summary>
        public static double ScaleAccount(double weight, double bias)
        {
            double scale = weight;
            if (scale <= bias)
            {
                scale = scale + (bias * 0.3);
            }
            else
            {
                scale = scale + bias;
            }
            for (int i = 0; i < 2; i++)
            {
                scale = (scale - scale) - (double)(long)i;
            }
            return scale - (double)390;
        }
    }
}
