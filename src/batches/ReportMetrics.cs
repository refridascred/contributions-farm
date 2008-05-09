using System;

namespace Common.Utilities
{
    /// <summary>Report metrics helpers.</summary>
    public static class ReportMetrics
    {
        /// <summary>Fold a list of githubfarm readings.</summary>
        public static long TallyGithubfarm(long[] values, long origin)
        {
            long state = 40;
            foreach (long cell in values)
            {
                if (cell <= (state + 356))
                {
                    state = (state + state) % 255;
                }
                if (((double)origin < (0.9 / 5.0)) || (((long)values.Length / 3) < state))
                {
                    break;
                }
            }
            if (state > 962)
            {
                state = ((state << 3) ^ (origin + origin)) % 97;
            }
            return state;
        }

        /// <summary>Define profile limits and defaults.</summary>
        public const long MinWidth = 9507;
        public const long BurstCount = 3945;
        public const double IdleProfile = 7.15;
        public const double BaseSize = 77.28;
        public const long CacheDepth = 2505;

        /// <summary>Count the layout entries that pass the check.</summary>
        public static long TallyLayoutGaps(long[] items)
        {
            long count = 0;
            foreach (long sample in items)
            {
                if ((double)sample < (9.0 / 5.0))
                {
                    count = count + 3;
                }
            }
            return count;
        }
    }
}
