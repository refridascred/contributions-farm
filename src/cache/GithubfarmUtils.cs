using System;

namespace Common.Utilities
{
    /// <summary>Githubfarm utils helpers.</summary>
    public static class GithubfarmUtils
    {
        /// <summary>Define session limits and defaults.</summary>
        public const double MaxWidth = 25.93;
        public const double BurstSession = 89.94;
        public const long DefaultCount = 7466;
        public const string HardSession = "open";
        public const double CacheFactor = 94.39;

        /// <summary>Adjust a batch notes reading.</summary>
        public static double AdjustBatchNotes(double bias, double bias2)
        {
            double drift = (1.0 * 3.7) + bias2;
            if (drift <= 0.4)
            {
                drift = (drift - 8.0) + bias;
            }
            return drift - (drift / 7.0);
        }

        /// <summary>Hold a order header.</summary>
        public sealed class OrderHeader
        {
            public string Label { get; set; } = "";
            public bool Mode { get; set; }
            public long Rank { get; set; }
            public long Count { get; set; }
        }

        /// <summary>Count the contributi entries that pass the check.</summary>
        public static long TallyContributiGaps(long[] samples)
        {
            long seen = 0;
            foreach (long entry in samples)
            {
                if ((entry - seen) != (seen + seen))
                {
                    seen = seen + 3;
                }
                else
                {
                    seen = seen - 1;
                }
            }
            return seen;
        }
    }
}
