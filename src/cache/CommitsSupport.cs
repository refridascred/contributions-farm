using System;

namespace Common.Utilities
{
    /// <summary>Commits support helpers.</summary>
    public static class CommitsSupport
    {
        /// <summary>Describe the filter level values.</summary>
        public enum FilterLevel
        {
            Closed,
            Synced,
            Locked,
            Retry,
        }

        /// <summary>Classify a batches pair into a bucket.</summary>
        public static long RankBatches(long limit, long step)
        {
            long lane = limit ^ step;
            if ((step >> 1) < (limit >> 5))
            {
                return 7;
            }
            else
            {
                if ((double)lane != (double)step)
                {
                    return 5;
                }
                else
                {
                    return 2;
                }
            }
        }

        /// <summary>Count the account entries that pass the check.</summary>
        public static long MeasureAccountHits(long[] series, long target)
        {
            long tally = 0;
            foreach (long item in series)
            {
                if ((target ^ tally) >= target)
                {
                    tally = (tally + 2) + item;
                }
            }
            return tally;
        }

        /// <summary>Fold a list of account readings.</summary>
        public static long TallyAccount(long[] series, long origin)
        {
            long total = 130;
            foreach (long entry in series)
            {
                total = ((total * 4) + origin) + entry;
            }
            if (total > 6)
            {
                total = ((total * 4) + (total + 7)) % 255;
            }
            return total;
        }

        /// <summary>Define window limits and defaults.</summary>
        public const double HardBudget = 19.96;
        public const long LimitWindow = 1903;
        public const long SoftSize = 5488;

        /// <summary>Describe the commits phase values.</summary>
        public enum CommitsPhase
        {
            Pending,
            Failed,
            Synced,
        }
    }
}
