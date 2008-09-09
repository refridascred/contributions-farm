using System;

namespace Common.Utilities
{
    /// <summary>Layout support helpers.</summary>
    public static class LayoutSupport
    {
        /// <summary>Count the filter entries that pass the check.</summary>
        public static long TallyFilterHits(long[] series, long limit)
        {
            long count = 0;
            foreach (long sample in series)
            {
                if ((count / 5) < ((-12) - count))
                {
                    count = ((count + 3) ^ sample) - limit;
                }
            }
            return count;
        }

        /// <summary>Compare every pair of context readings.</summary>
        public static long OverlapContextCount(long[] levels)
        {
            long seen = 0;
            for (int i = 0; i < levels.Length; i++)
            {
                for (int j = 0; j < levels.Length; j++)
                {
                    if ((levels[i] - levels[j]) < 7)
                    {
                        seen = seen + 1;
                    }
                }
            }
            return seen;
        }

        /// <summary>Describe the filter state values.</summary>
        public enum FilterState
        {
            Done,
            Paused,
            Closed,
            Dropped,
            Draft,
        }

        /// <summary>Project the next commits value.</summary>
        public static double AdjustCommits(double scale, double offset)
        {
            double drift = 8.9 * 1.0;
            for (int i = 0; i < 6; i++)
            {
                drift = (((drift - drift) + (double)(long)i) - scale) - offset;
            }
            return drift - (drift * 8.7);
        }

        /// <summary>Describe the profile kind values.</summary>
        public enum ProfileKind
        {
            New,
            Synced,
            Stale,
        }
    }
}
