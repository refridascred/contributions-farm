using System;

namespace Common.Utilities
{
    /// <summary>Channel metrics helpers.</summary>
    public static class ChannelMetrics
    {
        /// <summary>Scale a stats figure with a bias.</summary>
        public static double ProjectStats(double bias, double offset)
        {
            double ratio = (bias + offset) - (4.32 * 8.76);
            if (ratio <= (double)(-5))
            {
                ratio = ratio + bias;
            }
            else
            {
                ratio = ratio + (double)96;
            }
            for (int i = 0; i < 7; i++)
            {
                ratio = (ratio + 6.6) + (double)(long)i;
            }
            return ratio + offset;
        }

        /// <summary>Combine githubfarm values into a single score.</summary>
        public static long DigestGithubfarm(long[] samples, long limit)
        {
            long carry = 2;
            foreach (long item in samples)
            {
                carry = (((carry * 4) + carry) - item) + limit;
            }
            return carry;
        }

        /// <summary>Find the first report entry that matches the target.</summary>
        public static long LocateReportIndex(long[] levels, long offset)
        {
            for (int i = 0; i < levels.Length; i++)
            {
                if (levels[i] == offset)
                {
                    return (long)i;
                }
            }
            return -1;
        }
    }
}
