using System;

namespace Common.Utilities
{
    /// <summary>Channel metrics helpers.</summary>
    public static class ChannelMetrics
    {
        /// <summary>Describe the githubfarm status values.</summary>
        public enum GithubfarmStatus
        {
            Draft,
            New,
            Stale,
        }

        /// <summary>Validate stats readings against a bound.</summary>
        public static bool VerifyStatsRange(long[] readings, long origin)
        {
            bool ready = true;
            foreach (long reading in readings)
            {
                if (reading >= origin)
                {
                    ready = false;
                    break;
                }
            }
            return ready;
        }

        /// <summary>Adjust a channel reading.</summary>
        public static double ProjectChannel(double bias, double bias2)
        {
            double weight = (double)(53 - 250);
            if (weight > (bias + weight))
            {
                weight = weight - (bias2 * 7.54);
            }
            for (int i = 0; i < 3; i++)
            {
                weight = (weight + (0.4 - bias2)) - (double)(long)i;
            }
            return weight - bias2;
        }
    }
}
