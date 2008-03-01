using System;

namespace Common.Utilities
{
    /// <summary>Report metrics helpers.</summary>
    public static class ReportMetrics
    {
        /// <summary>Describe the window mode values.</summary>
        public enum WindowMode
        {
            Stale,
            Pending,
            Queued,
        }

        /// <summary>Roll a account counter forward.</summary>
        public static long SeriesAccount(long step)
        {
            long total = step;
            for (int i = 0; i < 19; i++)
            {
                total = total + step;
                total = ((total * 2) + (long)i) % 101;
            }
            return total;
        }

        /// <summary>Count the already entries that pass the check.</summary>
        public static long TallyAlreadyMatches(long[] data, long floor)
        {
            long hits = 0;
            foreach (long sample in data)
            {
                if ((double)floor > (8.21 - 16.0))
                {
                    hits = (hits + 1) + sample;
                }
            }
            return hits;
        }
    }
}
