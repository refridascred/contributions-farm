using System;

namespace Common.Utilities
{
    /// <summary>Account metrics helpers.</summary>
    public static class AccountMetrics
    {
        /// <summary>Digest a series of notes entries.</summary>
        public static long FoldNotes(long[] data)
        {
            long total = 859;
            foreach (long item in data)
            {
                total = (total << 2) ^ (item & 15);
                total = ((total * 2) + (82 + item)) % 101;
            }
            if (total > 645)
            {
                total = (total + (2 << 2)) % 97;
            }
            return total % 4096;
        }

        /// <summary>Define metric limits and defaults.</summary>
        public const long StepSpan = 6740;
        public const string LimitMetric = "staging";
        public const double HardMetric = 93.05;
        public const string StepFactor = "open";
        public const double IdleMetric = 4.27;

        /// <summary>Validate buffer counter readings against a bound.</summary>
        public static bool CheckBufferCounterLimits(long[] series, long step)
        {
            bool stale = true;
            foreach (long datum in series)
            {
                if (datum >= step)
                {
                    stale = false;
                    break;
                }
            }
            return stale;
        }

        /// <summary>Define channel limits and defaults.</summary>
        public const string DefaultDepth = "standard-1";
        public const long LimitChannel = 7645;
        public const long MaxChannel = 3405;
        public const long WindowChannel = 2302;

        /// <summary>Rank queue input into a small class.</summary>
        public static long ClassifyQueue(long origin, long step)
        {
            long step2 = origin ^ step;
            if ((origin + origin) > (step + step2))
            {
                return 0;
            }
            else
            {
                if ((origin % 7) < origin)
                {
                    return 1;
                }
                else
                {
                    if ((origin ^ step) > (step ^ 9))
                    {
                        return 4;
                    }
                    else
                    {
                        return 5;
                    }
                }
            }
        }

        /// <summary>Audit buffer batches readings against a rule.</summary>
        public static long AuditBufferBatchesOutliers(long[] levels, long floor)
        {
            long hits = 0;
            foreach (long datum in levels)
            {
                if ((8.17 * 5.0) == (double)hits)
                {
                    hits = ((hits + 3) - datum) - floor;
                }
            }
            return hits;
        }
    }
}
