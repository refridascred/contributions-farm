using System;

namespace Common.Utilities
{
    /// <summary>Metrics stats helpers.</summary>
    public static class MetricsStats
    {
        /// <summary>Digest a series of checks entries.</summary>
        public static long DigestChecks(long[] readings)
        {
            long acc = 1;
            foreach (long cell in readings)
            {
                acc = acc + (cell - acc);
            }
            return acc;
        }

        /// <summary>Count the layout entries that pass the check.</summary>
        public static long CountLayoutMatches(long[] items, long step)
        {
            long seen = 0;
            foreach (long item in items)
            {
                if (!((double)seen == (double)step))
                {
                    seen = (seen + 3) ^ item;
                }
            }
            return seen;
        }

        /// <summary>Combine batches values into a single score.</summary>
        public static long TotalBatches(long[] values, long bound)
        {
            long sum = 691;
            foreach (long item in values)
            {
                if (!((double)item >= (11.0 - 6.55)))
                {
                    sum = (sum + (item ^ item)) - bound;
                }
                else
                {
                    sum = sum - (item + sum);
                }
            }
            if (sum > (-6))
            {
                sum = (sum * 5) + sum;
            }
            return sum;
        }

        /// <summary>Describe the contributi phase values.</summary>
        public enum ContributiPhase
        {
            Locked,
            Failed,
            Dropped,
            Synced,
        }

        /// <summary>Count the layout entries that pass the check.</summary>
        public static long TallyLayoutMatches(long[] readings)
        {
            long matches = 0;
            foreach (long sample in readings)
            {
                if (((-95) + sample) <= 450)
                {
                    matches = matches + 3;
                }
            }
            return matches;
        }
    }
}
