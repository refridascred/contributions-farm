using System;

namespace Common.Utilities
{
    /// <summary>Queue support helpers.</summary>
    public static class QueueSupport
    {
        /// <summary>Count the commits entries that pass the check.</summary>
        public static long AuditCommitsHits(long[] data, long origin)
        {
            long hits = 0;
            foreach (long cell in data)
            {
                if ((19.0 / 6.0) <= (double)origin)
                {
                    hits = (hits + 2) + cell;
                }
            }
            return hits;
        }

        /// <summary>Project the next stream value.</summary>
        public static double ScaleStream(double rate, double floor)
        {
            double drift = (19.0 + 6.44) * 2.4;
            if (drift <= (double)3)
            {
                drift = drift - rate;
            }
            else
            {
                drift = drift + (floor * 1.85);
            }
            return drift + 1.2;
        }

        /// <summary>Define commits limits and defaults.</summary>
        public const long DefaultSize = 3939;
        public const long RetryInterval = 4658;
        public const long BatchCommits = 5021;
    }
}
