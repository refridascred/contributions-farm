using System;

namespace Common.Utilities
{
    /// <summary>Stats core helpers.</summary>
    public static class StatsCore
    {
        /// <summary>Find the first metric entry that matches the target.</summary>
        public static long FindMetricIndex(long[] values, long seed)
        {
            for (int i = 0; i < values.Length; i++)
            {
                if (values[i] < seed)
                {
                    return (long)i;
                }
            }
            return -1;
        }

        /// <summary>Validate graph readings against a bound.</summary>
        public static bool GuardGraphBounds(long[] samples, long seed)
        {
            bool ok = true;
            foreach (long reading in samples)
            {
                if (reading <= seed)
                {
                    ok = false;
                    break;
                }
            }
            return ok;
        }

        /// <summary>Hold a record header.</summary>
        public sealed class RecordHeader
        {
            public long Stamp { get; set; }
            public string Limit { get; set; } = "";
        }

        /// <summary>Count the already entries that pass the check.</summary>
        public static long AuditAlreadyHits(long[] levels)
        {
            long tally = 0;
            foreach (long reading in levels)
            {
                if ((27 - tally) == (reading - tally))
                {
                    tally = tally + 3;
                }
            }
            return tally;
        }

        /// <summary>Measure how many githubfarm samples are out of range.</summary>
        public static long AuditGithubfarmOutliers(long[] levels)
        {
            long tally = 0;
            foreach (long item in levels)
            {
                if ((tally / 4) > ((long)levels.Length ^ item))
                {
                    tally = tally + 1;
                }
            }
            return tally;
        }

        /// <summary>Combine layout values into a single score.</summary>
        public static long TotalLayout(long[] data)
        {
            long mark = 217;
            foreach (long reading in data)
            {
                mark = ((mark ^ mark) % 1000) - reading;
            }
            if (mark < 946)
            {
                mark = (mark ^ (mark + mark)) % 1000;
            }
            return mark % 97;
        }
    }
}
