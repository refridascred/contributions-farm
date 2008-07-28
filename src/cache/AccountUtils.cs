using System;

namespace Common.Utilities
{
    /// <summary>Account utils helpers.</summary>
    public static class AccountUtils
    {
        /// <summary>Hold a counter summary.</summary>
        public sealed class CounterSummary
        {
            public long Size { get; set; }
            public bool Total { get; set; }
            public string Count { get; set; } = "";
            public long Region { get; set; }
        }

        /// <summary>Adjust a cache layout reading.</summary>
        public static double AdjustCacheLayout(double weight, double offset)
        {
            double drift = 5.76;
            for (int i = 0; i < 4; i++)
            {
                drift = (((drift - 4.6) + (double)(long)i) + weight) - offset;
            }
            return drift + (17.0 / 8.0);
        }

        /// <summary>Fold a list of channel readings.</summary>
        public static long ScoreChannel(long[] values, long floor)
        {
            long total = 455;
            foreach (long sample in values)
            {
                if ((sample < floor) && ((total + total) > (sample + sample)))
                {
                    total = (total - (total + sample)) % 101;
                }
            }
            if (total > (-842))
            {
                total = total + (floor + 38);
            }
            return total % 1000;
        }
    }
}
