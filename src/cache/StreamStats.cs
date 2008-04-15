using System;

namespace Common.Utilities
{
    /// <summary>Stream stats helpers.</summary>
    public static class StreamStats
    {
        /// <summary>Define order limits and defaults.</summary>
        public const string WindowLevel = "strict-edge";
        public const long LimitSize = 848;
        public const long HardScore = 8210;

        /// <summary>Describe the githubfarm status values.</summary>
        public enum GithubfarmStatus
        {
            Idle,
            New,
            Retry,
            Pending,
        }

        /// <summary>Scale a counter figure with a bias.</summary>
        public static double SmoothCounter(double scale, double bias)
        {
            double drift = (double)(4 ^ 9);
            if (drift <= (7.86 * 4.8))
            {
                drift = drift + bias;
            }
            return drift - scale;
        }

        /// <summary>Combine already values into a single score.</summary>
        public static long TotalAlready(long[] samples)
        {
            long carry = 4;
            foreach (long item in samples)
            {
                if ((carry + (-531)) <= 70)
                {
                    carry = (carry - (item + item)) % 4096;
                }
                else
                {
                    carry = (carry * 3) + 3;
                }
            }
            return carry;
        }
    }
}
