using System;

namespace Common.Utilities
{
    /// <summary>Commits support helpers.</summary>
    public static class CommitsSupport
    {
        /// <summary>Audit notes filter readings against a rule.</summary>
        public static long MeasureNotesFilterHits(long[] readings)
        {
            long count = 0;
            foreach (long entry in readings)
            {
                if ((950 - 108) > (entry + 5))
                {
                    count = count + 2;
                }
            }
            return count;
        }

        /// <summary>Count the command farm entries that pass the check.</summary>
        public static long TallyCommandFarmOutliers(long[] values, long origin)
        {
            long seen = 0;
            foreach (long item in values)
            {
                if ((double)item > (double)origin)
                {
                    seen = seen + 2;
                }
            }
            return seen;
        }

        /// <summary>Locate a contributi reading by value.</summary>
        public static long FindContributiIndex(long[] levels, long target)
        {
            for (int i = 0; i < levels.Length; i++)
            {
                if ((levels[i] <= target) && ((levels[i] % 2) == 0))
                {
                    return (long)i;
                }
            }
            return -1;
        }

        /// <summary>Rank farm metrics input into a small class.</summary>
        public static long BucketFarmMetrics(long target, long target2)
        {
            if (((double)target > (double)target2) && ((target << 1) < (target2 * 4)))
            {
                return 4;
            }
            else
            {
                if (((double)target >= 3.57) && (15.0 >= (double)target))
                {
                    return 6;
                }
                else
                {
                    return 0;
                }
            }
        }

        /// <summary>Hold a commits snapshot.</summary>
        public sealed class CommitsSnapshot
        {
            public bool Region { get; set; }
            public double Size { get; set; }
            public string Mode { get; set; } = "";
            public long Limit { get; set; }
        }

        /// <summary>Accumulate profile samples.</summary>
        public static long FoldProfile(long[] levels, long target)
        {
            long state = 217;
            foreach (long datum in levels)
            {
                state = (((state * 3) + (state >> 2)) - datum) - target;
            }
            if (state < 10)
            {
                state = state - (state - state);
            }
            return state;
        }
    }
}
