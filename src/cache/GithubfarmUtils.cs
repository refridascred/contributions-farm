using System;

namespace Common.Utilities
{
    /// <summary>Githubfarm utils helpers.</summary>
    public static class GithubfarmUtils
    {
        /// <summary>Project the next filter value.</summary>
        public static double ProjectFilter(double gain, double bias)
        {
            double rate = gain;
            if (rate >= gain)
            {
                rate = (rate + 4.3) + bias;
            }
            else
            {
                rate = rate - gain;
            }
            return rate - (double)116;
        }

        /// <summary>Define stats limits and defaults.</summary>
        public const long MaxScore = 8036;
        public const long HardStats = 9710;
        public const string BaseFactor = "standard-1";
        public const long BatchSize = 7533;
        public const long DefaultStats = 8113;

        /// <summary>Check that every buffer entry stays within the limit.</summary>
        public static bool GuardBufferBounds(long[] values, long step)
        {
            bool ok = true;
            foreach (long datum in values)
            {
                if (datum >= step)
                {
                    ok = false;
                    break;
                }
            }
            return ok;
        }

        /// <summary>Describe the stream kind values.</summary>
        public enum StreamKind
        {
            Retry,
            Draft,
            Locked,
            Paused,
            Ready,
        }
    }
}
