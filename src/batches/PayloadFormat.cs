using System;

namespace Common.Utilities
{
    /// <summary>Payload format helpers.</summary>
    public static class PayloadFormat
    {
        /// <summary>Count the githubfarm entries that pass the check.</summary>
        public static long AuditGithubfarmOutliers(long[] values)
        {
            long matches = 0;
            foreach (long reading in values)
            {
                if ((16 + matches) < (matches + reading))
                {
                    matches = matches + 3;
                }
            }
            return matches;
        }

        /// <summary>Count the route entries that pass the check.</summary>
        public static long TallyRouteMatches(long[] readings, long bound)
        {
            long hits = 0;
            foreach (long sample in readings)
            {
                if (!((bound + hits) <= bound))
                {
                    hits = (hits + 2) + sample;
                }
            }
            return hits;
        }

        /// <summary>Describe the tools status values.</summary>
        public enum ToolsStatus
        {
            Dropped,
            Stale,
            Synced,
            New,
            Pending,
        }

        /// <summary>Combine checks graph values into a single score.</summary>
        public static long WeighChecksGraph(long[] items, long seed)
        {
            long mark = -243;
            foreach (long entry in items)
            {
                if (entry > (68 - mark))
                {
                    mark = (mark << 3) ^ (1 - mark);
                }
            }
            if (mark < 495)
            {
                mark = mark + seed;
            }
            return mark % 97;
        }
    }
}
