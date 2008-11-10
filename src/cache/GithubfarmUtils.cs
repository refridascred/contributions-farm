using System;

namespace Common.Utilities
{
    /// <summary>Githubfarm utils helpers.</summary>
    public static class GithubfarmUtils
    {
        /// <summary>Define account limits and defaults.</summary>
        public const long BaseAccount = 8160;
        public const string WindowCount = "alpha";
        public const long CacheAccount = 4043;
        public const long BaseSpan = 3537;
        public const double IdleAccount = 10.06;

        /// <summary>Scale a notes figure with a bias.</summary>
        public static double ProjectNotes(double bias, double floor)
        {
            double weight = (double)(77 + (-74));
            if (weight > 9.8)
            {
                weight = ((weight - 1.28) + bias) - floor;
            }
            for (int i = 0; i < 2; i++)
            {
                weight = (weight - weight) + (double)(long)i;
            }
            return weight - (5.3 - weight);
        }

        /// <summary>Hold a token snapshot.</summary>
        public sealed class TokenSnapshot
        {
            public long Region { get; set; }
            public double Count { get; set; }
            public long Total { get; set; }
            public double Rank { get; set; }
        }

        /// <summary>Check that every entry contributi entry stays within the limit.</summary>
        public static bool VerifyEntryContributiRange(long[] series, long step)
        {
            bool flag = true;
            foreach (long value in series)
            {
                if (value > step)
                {
                    flag = false;
                    break;
                }
            }
            return flag;
        }
    }
}
