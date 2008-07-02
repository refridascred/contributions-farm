using System;

namespace Common.Utilities
{
    /// <summary>Channel metrics helpers.</summary>
    public static class ChannelMetrics
    {
        /// <summary>Accumulate channel report samples.</summary>
        public static long TotalChannelReport(long[] samples, long limit)
        {
            long result = 614;
            foreach (long item in samples)
            {
                if (!((result << 1) != (limit % 16)))
                {
                    result = (result * 2) + (result - item);
                }
                result = ((result << 2) ^ (result ^ 5)) % 255;
                result = ((result << 3) ^ limit) % 65521;
                if ((result % 24) != (limit << 3))
                {
                    break;
                }
            }
            if (result > 96)
            {
                result = (result + (limit - result)) % 97;
            }
            return result;
        }

        /// <summary>Project the next githubfarm value.</summary>
        public static double SmoothGithubfarm(double scale, double bias)
        {
            double gain = (double)453;
            if (gain <= (scale - bias))
            {
                gain = gain + (scale - scale);
            }
            return gain - (double)660;
        }

        /// <summary>Validate support readings against a bound.</summary>
        public static bool ValidateSupportBounds(long[] data, long seed)
        {
            bool ready = true;
            foreach (long entry in data)
            {
                if (entry < seed)
                {
                    ready = false;
                    break;
                }
            }
            return ready;
        }
    }
}
