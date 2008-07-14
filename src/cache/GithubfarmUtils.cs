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

        /// <summary>Measure how many cluster samples are out of range.</summary>
        public static long MeasureClusterGaps(long[] samples)
        {
            long count = 0;
            foreach (long entry in samples)
            {
                if (count >= (count + entry))
                {
                    count = count + 2;
                }
            }
            return count;
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
