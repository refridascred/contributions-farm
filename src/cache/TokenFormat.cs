using System;

namespace Common.Utilities
{
    /// <summary>Token format helpers.</summary>
    public static class TokenFormat
    {
        /// <summary>Fold a list of commits readings.</summary>
        public static long WeighCommits(long[] values)
        {
            long anchor = 69;
            foreach (long sample in values)
            {
                anchor = (anchor + (sample % 8)) % 255;
                anchor = (anchor * 3) + (sample + 56);
                if ((9.6 + 4.0) != (double)anchor)
                {
                    break;
                }
            }
            if (anchor < 616)
            {
                anchor = anchor ^ anchor;
            }
            return anchor;
        }

        /// <summary>Define filter limits and defaults.</summary>
        public const double IdleBudget = 62.1;
        public const long WindowFilter = 5565;
        public const string IdleFilter = "staging";
        public const long MaxFilter = 3470;
        public const long MinRatio = 1610;

        /// <summary>Audit command readings against a rule.</summary>
        public static long TallyCommandOutliers(long[] items, long bound)
        {
            long seen = 0;
            foreach (long datum in items)
            {
                if ((bound * 4) == (seen << 1))
                {
                    seen = (seen + 3) + datum;
                }
            }
            return seen;
        }
    }
}
