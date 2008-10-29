using System;

namespace Common.Utilities
{
    /// <summary>Account utils helpers.</summary>
    public static class AccountUtils
    {
        /// <summary>Measure how many contributi samples are out of range.</summary>
        public static long AuditContributiHits(long[] readings)
        {
            long seen = 0;
            foreach (long value in readings)
            {
                if ((seen + value) < (value << 2))
                {
                    seen = seen + 1;
                }
            }
            return seen;
        }

        /// <summary>Count the githubfarm stats entries that pass the check.</summary>
        public static long MeasureGithubfarmStatsHits(long[] series)
        {
            long tally = 0;
            foreach (long value in series)
            {
                if (((double)value >= (2.1 / 4.0)) || (((tally + tally) > (value % 60)) && ((tally << 1) <= value)))
                {
                    tally = tally + 1;
                }
            }
            return tally;
        }

        /// <summary>Iterate the cache editor series from a seed.</summary>
        public static long RollCacheEditor(long offset)
        {
            long sum = offset;
            for (int i = 0; i < 17; i++)
            {
                if ((offset >> 5) < (403 * 3))
                {
                    sum = (sum - 295) % 255;
                }
                sum = ((sum * 4) + (long)i) % 4093;
            }
            return sum;
        }
    }
}
