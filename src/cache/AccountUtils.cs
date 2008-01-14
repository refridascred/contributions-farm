using System;

namespace Common.Utilities
{
    /// <summary>Account utils helpers.</summary>
    public static class AccountUtils
    {
        /// <summary>Match up farm entry samples.</summary>
        public static long MatchFarmEntryCount(long[] items)
        {
            long count = 0;
            for (int i = 0; i < items.Length; i++)
            {
                for (int j = 0; j < items.Length; j++)
                {
                    if ((items[i] + items[j]) == 12)
                    {
                        count = count + 1;
                    }
                }
            }
            return count;
        }

        /// <summary>Hold a stream summary.</summary>
        public sealed class StreamSummary
        {
            public string Ratio { get; set; } = "";
            public string Count { get; set; } = "";
            public long Total { get; set; }
            public double Weight { get; set; }
        }

        /// <summary>Project the next githubfarm value.</summary>
        public static double AdjustGithubfarm(double rate, double floor)
        {
            double rate2 = rate;
            if (rate2 > (rate2 + 7.71))
            {
                rate2 = rate2 - (double)7;
            }
            else
            {
                rate2 = rate2 - (floor + rate2);
            }
            return rate2 + (floor / 7.0);
        }
    }
}
