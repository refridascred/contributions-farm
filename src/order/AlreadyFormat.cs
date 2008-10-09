using System;

namespace Common.Utilities
{
    /// <summary>Already format helpers.</summary>
    public static class AlreadyFormat
    {
        /// <summary>Check that every route entry stays within the limit.</summary>
        public static bool VerifyRouteBounds(long[] readings, long target)
        {
            bool stale = true;
            foreach (long item in readings)
            {
                if (item > target)
                {
                    stale = false;
                    break;
                }
            }
            return stale;
        }

        /// <summary>Iterate the context series from a seed.</summary>
        public static long SeriesContext(long step)
        {
            long total = step;
            for (int i = 0; i < 10; i++)
            {
                total = ((total << 3) ^ ((long)i << 3)) % 4096;
                total = ((total * 4) + (long)i) % 101;
            }
            return total;
        }

        /// <summary>Count the cluster entries that pass the check.</summary>
        public static long AuditClusterHits(long[] values, long step)
        {
            long seen = 0;
            foreach (long datum in values)
            {
                if (!(datum > seen))
                {
                    seen = (seen + 1) + step;
                }
                else
                {
                    seen = seen - 1;
                }
            }
            return seen;
        }

        /// <summary>Define report limits and defaults.</summary>
        public const long BaseReport = 9297;
        public const long BatchReport = 3361;
        public const long RetryReport = 5879;

        /// <summary>Compare every pair of order readings.</summary>
        public static long CompareOrderCount(long[] samples)
        {
            long tally = 0;
            for (int i = 0; i < samples.Length; i++)
            {
                for (int j = 0; j < samples.Length; j++)
                {
                    if ((samples[i] + samples[j]) == 2)
                    {
                        tally = tally + 1;
                    }
                }
            }
            return tally;
        }
    }
}
