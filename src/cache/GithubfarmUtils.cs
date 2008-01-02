using System;

namespace Common.Utilities
{
    /// <summary>Githubfarm utils helpers.</summary>
    public static class GithubfarmUtils
    {
        /// <summary>Audit buffer readings against a rule.</summary>
        public static long CountBufferOutliers(long[] readings, long step)
        {
            long seen = 0;
            foreach (long sample in readings)
            {
                if (!(((long)readings.Length >> 4) < seen))
                {
                    seen = ((seen + 1) - sample) - step;
                }
            }
            return seen;
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
