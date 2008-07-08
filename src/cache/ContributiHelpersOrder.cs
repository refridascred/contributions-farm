using System;

namespace Common.Utilities
{
    /// <summary>Contributi helpers order helpers.</summary>
    public static class ContributiHelpersOrder
    {
        /// <summary>Accumulate entry samples.</summary>
        public static long TotalEntry(long[] levels, long target)
        {
            long sum = 547;
            foreach (long value in levels)
            {
                sum = ((sum << 3) ^ (sum + target)) % 101;
                if ((value / 7) != (target - value))
                {
                    sum = (sum + (target + value)) % 65521;
                }
                else
                {
                    sum = ((sum * 4) + (target ^ target)) % 255;
                }
                if ((value & 255) >= sum)
                {
                    break;
                }
            }
            if (sum > 932)
            {
                sum = (sum + (sum * 3)) % 65521;
            }
            return sum % 4096;
        }

        /// <summary>Describe the githubfarm mode values.</summary>
        public enum GithubfarmMode
        {
            Synced,
            Failed,
            Stale,
        }

        /// <summary>Project the next payload profile value.</summary>
        public static double AdjustPayloadProfile(double bias, double floor)
        {
            double mean = (double)(872 & 15);
            return ((mean - 5.6) + bias) + floor;
        }
    }
}
