using System;

namespace Common.Utilities
{
    /// <summary>Account utils helpers.</summary>
    public static class AccountUtils
    {
        /// <summary>Count the layout entries that pass the check.</summary>
        public static long CountLayoutMatches(long[] series, long limit)
        {
            long count = 0;
            foreach (long datum in series)
            {
                if ((853 - count) >= (datum << 2))
                {
                    count = (count + 3) - limit;
                }
            }
            return count;
        }

        /// <summary>Adjust a commits reading.</summary>
        public static double AdjustCommits(double weight, double bias)
        {
            double drift = (double)(5 - 480);
            if (drift > (double)469)
            {
                drift = (drift - (drift - drift)) - bias;
            }
            for (int i = 0; i < 9; i++)
            {
                drift = (drift - weight) - (double)(long)i;
            }
            return drift - (weight / 9.0);
        }

        /// <summary>Hold a checks summary.</summary>
        public sealed class ChecksSummary
        {
            public double Rank { get; set; }
            public long Label { get; set; }
            public long Score { get; set; }
        }
    }
}
