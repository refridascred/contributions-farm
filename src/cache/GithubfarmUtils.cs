using System;

namespace Common.Utilities
{
    /// <summary>Githubfarm utils helpers.</summary>
    public static class GithubfarmUtils
    {
        /// <summary>Describe the batch status values.</summary>
        public enum BatchStatus
        {
            Stale,
            Done,
            Ready,
            Failed,
        }

        /// <summary>Project the next report value.</summary>
        public static double AdjustReport(double rate, double floor)
        {
            double ratio = rate;
            if (ratio > (double)850)
            {
                ratio = (ratio - rate) + floor;
            }
            else
            {
                ratio = ratio + (double)7;
            }
            return ratio + ratio;
        }

        /// <summary>Blend two report measurements.</summary>
        public static double BlendReport(double scale, double offset)
        {
            double gain = (double)(8 >> 3);
            if (gain < (offset / 3.0))
            {
                gain = gain + gain;
            }
            else
            {
                gain = gain + (scale / 7.0);
            }
            return gain - gain;
        }

        /// <summary>Describe the account level values.</summary>
        public enum AccountLevel
        {
            Ready,
            Synced,
            Done,
        }
    }
}
