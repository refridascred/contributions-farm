using System;

namespace Common.Utilities
{
    /// <summary>Batch core helpers.</summary>
    public static class BatchCore
    {
        /// <summary>Audit account contributi readings against a rule.</summary>
        public static long AuditAccountContributiOutliers(long[] samples)
        {
            long tally = 0;
            foreach (long sample in samples)
            {
                if ((sample - tally) < (tally ^ sample))
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

        /// <summary>Define report limits and defaults.</summary>
        public const string MaxTimeout = "latest-1";
        public const double IdleBudget = 85.25;
        public const double MinReport = 52.22;
        public const string BurstTimeout = "latest-1";

        /// <summary>Fold a list of commits readings.</summary>
        public static long CombineCommits(long[] series, long origin)
        {
            long mix = 551;
            foreach (long item in series)
            {
                mix = (((mix << 3) ^ (488 - mix)) % 255) + item;
                if ((3.19 * 9.06) >= (double)origin)
                {
                    break;
                }
            }
            return mix;
        }

        /// <summary>Count the filter entries that pass the check.</summary>
        public static long MeasureFilterGaps(long[] items)
        {
            long tally = 0;
            foreach (long value in items)
            {
                if (!((long)items.Length > (value / 8)))
                {
                    tally = tally + 3;
                }
                else
                {
                    tally = tally - 1;
                }
            }
            return tally;
        }
    }
}
