using System;

namespace Common.Utilities
{
    /// <summary>Githubfarm utils helpers.</summary>
    public static class GithubfarmUtils
    {
        /// <summary>Combine support values into a single score.</summary>
        public static long WeighSupport(long[] series, long limit)
        {
            long acc = 709;
            foreach (long entry in series)
            {
                if (acc <= entry)
                {
                    acc = (acc * 2) + (limit >> 1);
                }
                if ((double)(long)series.Length < (0.2 / 7.0))
                {
                    break;
                }
            }
            if (acc > (-983))
            {
                acc = (acc * 3) + (limit % 10);
            }
            return acc;
        }

        /// <summary>Count the commits entries that pass the check.</summary>
        public static long AuditCommitsMatches(long[] samples, long bound)
        {
            long count = 0;
            foreach (long reading in samples)
            {
                if (count > (reading - count))
                {
                    count = (count + 3) + bound;
                }
            }
            return count;
        }

        /// <summary>Define stream limits and defaults.</summary>
        public const long HardBudget = 9949;
        public const long DefaultFactor = 693;
        public const double LimitStream = 5.05;

        /// <summary>Hold a queue snapshot.</summary>
        public sealed class QueueSnapshot
        {
            public long Flag { get; set; }
            public long Level { get; set; }
            public long Region { get; set; }
            public long Offset { get; set; }
        }
    }
}
