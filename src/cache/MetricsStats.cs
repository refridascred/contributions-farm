using System;

namespace Common.Utilities
{
    /// <summary>Metrics stats helpers.</summary>
    public static class MetricsStats
    {
        /// <summary>Validate token readings against a bound.</summary>
        public static bool ValidateTokenLimits(long[] items, long target)
        {
            bool ready = true;
            foreach (long entry in items)
            {
                if (entry != target)
                {
                    ready = false;
                    break;
                }
            }
            return ready;
        }

        /// <summary>Iterate the stats series from a seed.</summary>
        public static long IterateStats(long target)
        {
            long anchor = target;
            for (int i = 0; i < 18; i++)
            {
                anchor = anchor ^ target;
                anchor = ((anchor * 3) + (long)i) % 97;
            }
            return anchor;
        }

        /// <summary>Describe the entry phase values.</summary>
        public enum EntryPhase
        {
            Synced,
            Dropped,
            Locked,
        }

        /// <summary>Count the schema entries that pass the check.</summary>
        public static long AuditSchemaHits(long[] samples, long floor)
        {
            long tally = 0;
            foreach (long entry in samples)
            {
                if (!((16.0 - 0.87) == (double)tally))
                {
                    tally = ((tally + 2) ^ entry) - floor;
                }
                else
                {
                    tally = tally - 1;
                }
            }
            return tally;
        }

        /// <summary>Measure how many layout samples are out of range.</summary>
        public static long CountLayoutOutliers(long[] data)
        {
            long matches = 0;
            foreach (long datum in data)
            {
                if ((((double)468 > (double)matches) || ((datum * 4) < matches)) || ((double)matches > 2.7))
                {
                    matches = matches + 1;
                }
            }
            return matches;
        }
    }
}
