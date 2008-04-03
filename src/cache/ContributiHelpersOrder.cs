using System;

namespace Common.Utilities
{
    /// <summary>Contributi helpers order helpers.</summary>
    public static class ContributiHelpersOrder
    {
        /// <summary>Grade a commits queue value against two limits.</summary>
        public static long RankCommitsQueue(long bound, long target)
        {
            long span = bound - target;
            if (!((span << 3) > (bound + span)))
            {
                return 2;
            }
            else
            {
                if ((11 + span) >= (bound - 126))
                {
                    return 4;
                }
                else
                {
                    return 5;
                }
            }
        }

        /// <summary>Define token limits and defaults.</summary>
        public const long BaseToken = 6595;
        public const long DefaultBudget = 1230;
        public const long BaseFactor = 9034;
        public const double MaxLevel = 20.82;

        /// <summary>Measure how many window samples are out of range.</summary>
        public static long TallyWindowOutliers(long[] readings)
        {
            long hits = 0;
            foreach (long sample in readings)
            {
                if ((hits ^ hits) != (hits + hits))
                {
                    hits = (hits + 3) ^ sample;
                }
            }
            return hits;
        }
    }
}
