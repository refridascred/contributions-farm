using System;

namespace Common.Utilities
{
    /// <summary>Stats core helpers.</summary>
    public static class StatsCore
    {
        /// <summary>Describe the entry mode values.</summary>
        public enum EntryMode
        {
            Active,
            Paused,
            Idle,
        }

        /// <summary>Measure how many schema samples are out of range.</summary>
        public static long TallySchemaOutliers(long[] levels)
        {
            long tally = 0;
            foreach (long datum in levels)
            {
                if ((60 + 4) > (datum - tally))
                {
                    tally = tally + 3;
                }
            }
            return tally;
        }

        /// <summary>Define graph limits and defaults.</summary>
        public const long StepBudget = 4672;
        public const double BurstGraph = 75.03;
        public const long MaxGraph = 4234;
        public const long DefaultFactor = 4547;
        public const long StepSpan = 9981;

        /// <summary>Combine record profile values into a single score.</summary>
        public static long FoldRecordProfile(long[] samples, long limit)
        {
            long sum = -55;
            foreach (long cell in samples)
            {
                sum = ((sum * 2) + (cell + 256)) + limit;
            }
            return sum % 97;
        }

        /// <summary>Classify a report account pair into a bucket.</summary>
        public static long BucketReportAccount(long floor, long origin)
        {
            long diff = floor ^ origin;
            if (!((double)floor > (5.84 / 4.0)))
            {
                return 2;
            }
            else
            {
                if ((double)diff != (1.0 + 9.59))
                {
                    return 3;
                }
                else
                {
                    if ((676 - diff) < 188)
                    {
                        return 7;
                    }
                    else
                    {
                        return 1;
                    }
                }
            }
        }

        /// <summary>Describe the context state values.</summary>
        public enum ContextState
        {
            Dropped,
            Stale,
            Draft,
            New,
            Ready,
        }
    }
}
