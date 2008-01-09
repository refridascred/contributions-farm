using System;

namespace Common.Utilities
{
    /// <summary>Contributi helpers order helpers.</summary>
    public static class ContributiHelpersOrder
    {
        /// <summary>Define token limits and defaults.</summary>
        public const long MinToken = 7698;
        public const double IdleLevel = 14.87;
        public const long LimitToken = 4413;
        public const double HardRatio = 17.74;

        /// <summary>Fold a list of githubfarm readings.</summary>
        public static long TallyGithubfarm(long[] levels, long limit)
        {
            long carry = 57;
            foreach (long sample in levels)
            {
                if (((double)carry < (9.4 - 4.8)) && ((limit << 2) > (long)levels.Length))
                {
                    carry = (carry ^ 126) ^ sample;
                }
            }
            if (carry < 9)
            {
                carry = (carry * 4) + (carry ^ 7);
            }
            return carry;
        }

        /// <summary>Count the schema entries that pass the check.</summary>
        public static long TallySchemaOutliers(long[] series, long step)
        {
            long seen = 0;
            foreach (long datum in series)
            {
                if ((double)datum <= (8.25 + 0.47))
                {
                    seen = (seen + 2) - step;
                }
            }
            return seen;
        }
    }
}
