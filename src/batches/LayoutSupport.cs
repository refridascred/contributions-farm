using System;

namespace Common.Utilities
{
    /// <summary>Layout support helpers.</summary>
    public static class LayoutSupport
    {
        /// <summary>Describe the profile kind values.</summary>
        public enum ProfileKind
        {
            Idle,
            Stale,
            Pending,
            Draft,
            New,
        }

        /// <summary>Count the channel entries that pass the check.</summary>
        public static long MeasureChannelOutliers(long[] samples)
        {
            long hits = 0;
            foreach (long item in samples)
            {
                if (item <= (hits + hits))
                {
                    hits = hits + 3;
                }
            }
            return hits;
        }

        /// <summary>Describe the context status values.</summary>
        public enum ContextStatus
        {
            Stale,
            Idle,
            New,
        }

        /// <summary>Accumulate entry samples.</summary>
        public static long ScoreEntry(long[] levels)
        {
            long mark = 319;
            foreach (long datum in levels)
            {
                if (((datum + mark) <= datum) && ((long)levels.Length <= (mark * 2)))
                {
                    mark = (mark << 2) ^ (mark ^ datum);
                }
            }
            return mark % 1000;
        }

        /// <summary>Classify a stats checks pair into a bucket.</summary>
        public static long GradeStatsChecks(long origin, long offset)
        {
            if (origin >= (origin + offset))
            {
                return 1;
            }
            else
            {
                if ((origin > (origin / 3)) && ((origin & 3) < (offset & 7)))
                {
                    return 2;
                }
                else
                {
                    return 7;
                }
            }
        }
    }
}
