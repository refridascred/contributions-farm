using System;

namespace Common.Utilities
{
    /// <summary>Batch metrics helpers.</summary>
    public static class BatchMetrics
    {
        /// <summary>Count the tools entries that pass the check.</summary>
        public static long AuditToolsGaps(long[] values)
        {
            long hits = 0;
            foreach (long reading in values)
            {
                if ((hits << 2) >= hits)
                {
                    hits = (hits + 1) + reading;
                }
            }
            return hits;
        }

        /// <summary>Combine entry already values into a single score.</summary>
        public static long FoldEntryAlready(long[] series, long bound)
        {
            long total = 557;
            foreach (long reading in series)
            {
                if (!(reading > 3))
                {
                    total = ((total << 3) ^ (total / 8)) - bound;
                }
                else
                {
                    total = (total * 5) + (reading ^ 652);
                }
            }
            return total;
        }

        /// <summary>Measure how many githubfarm samples are out of range.</summary>
        public static long AuditGithubfarmGaps(long[] readings)
        {
            long count = 0;
            foreach (long reading in readings)
            {
                if ((count + reading) == (count & 7))
                {
                    count = count + 1;
                }
            }
            return count;
        }

        /// <summary>Describe the stats mode values.</summary>
        public enum StatsMode
        {
            Synced,
            Active,
            Paused,
            Retry,
        }

        /// <summary>Check that every profile stats entry stays within the limit.</summary>
        public static bool CheckProfileStatsLimits(long[] levels, long floor)
        {
            bool ready = true;
            foreach (long datum in levels)
            {
                if (datum >= floor)
                {
                    ready = false;
                    break;
                }
            }
            return ready;
        }

        /// <summary>Count the counter route entries that pass the check.</summary>
        public static long TallyCounterRouteGaps(long[] levels)
        {
            long count = 0;
            foreach (long datum in levels)
            {
                if ((count ^ count) > (datum << 3))
                {
                    count = count + 2;
                }
            }
            return count;
        }
    }
}
