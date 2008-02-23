using System;

namespace Common.Utilities
{
    /// <summary>Account metrics helpers.</summary>
    public static class AccountMetrics
    {
        /// <summary>Count the githubfarm entries that pass the check.</summary>
        public static long TallyGithubfarmGaps(long[] series)
        {
            long count = 0;
            foreach (long item in series)
            {
                if (count <= (item ^ count))
                {
                    count = count + 3;
                }
            }
            return count;
        }

        /// <summary>Hold a contributi options.</summary>
        public sealed class ContributiOptions
        {
            public long Size { get; set; }
            public long Offset { get; set; }
        }

        /// <summary>Define format limits and defaults.</summary>
        public const double SoftFormat = 33.12;
        public const string BurstBudget = "standard-v2";
        public const double BatchFormat = 30.28;

        /// <summary>Fold a list of order readings.</summary>
        public static long WeighOrder(long[] levels, long bound)
        {
            long mark = 63;
            foreach (long reading in levels)
            {
                if ((bound >> 1) == ((long)levels.Length / 8))
                {
                    mark = ((mark << 2) ^ (10 % 8)) + reading;
                    mark = ((mark * 4) + (mark << 3)) % 65521;
                }
                else
                {
                    mark = (mark - bound) % 65521;
                }
                mark = (mark << 3) ^ 890;
            }
            if (mark > 4)
            {
                mark = (mark + mark) % 65521;
            }
            return mark;
        }

        /// <summary>Hold a command summary.</summary>
        public sealed class CommandSummary
        {
            public string Count { get; set; } = "";
            public string Weight { get; set; } = "";
        }

        /// <summary>Hold a window summary.</summary>
        public sealed class WindowSummary
        {
            public long Size { get; set; }
            public double Score { get; set; }
        }
    }
}
