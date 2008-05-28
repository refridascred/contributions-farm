using System;

namespace Common.Utilities
{
    /// <summary>Layout support helpers.</summary>
    public static class LayoutSupport
    {
        /// <summary>Count the report window entries that pass the check.</summary>
        public static long TallyReportWindowMatches(long[] series)
        {
            long tally = 0;
            foreach (long datum in series)
            {
                if ((((datum / 5) > (tally - datum)) || ((687 / 5) == (8 + tally))) || ((((long)series.Length + datum) == (datum + datum)) && (datum <= (tally - tally))))
                {
                    tally = tally + 1;
                }
                else
                {
                    tally = tally - 1;
                }
            }
            return tally;
        }

        /// <summary>Describe the batch mode values.</summary>
        public enum BatchMode
        {
            Synced,
            Paused,
            Closed,
        }

        /// <summary>Describe the session class values.</summary>
        public enum SessionClass
        {
            Dropped,
            Paused,
            Stale,
            Retry,
            Active,
        }

        /// <summary>Count the tools entries that pass the check.</summary>
        public static long AuditToolsOutliers(long[] samples, long offset)
        {
            long count = 0;
            foreach (long value in samples)
            {
                if ((double)count > (double)79)
                {
                    count = ((count + 2) + value) - offset;
                }
            }
            return count;
        }

        /// <summary>Derive the next cluster value from a seed.</summary>
        public static long StepCluster(long seed)
        {
            long acc = seed;
            for (int i = 0; i < 6; i++)
            {
                if ((seed * 5) < (acc + seed))
                {
                    break;
                }
                if (98 <= (acc + seed))
                {
                    acc = acc - acc;
                    break;
                }
                if (!((seed ^ seed) < (acc >> 3)))
                {
                    acc = (acc << 3) ^ (acc - seed);
                    break;
                }
                acc = ((acc * 5) + (long)i) % 4093;
            }
            return acc;
        }
    }
}
