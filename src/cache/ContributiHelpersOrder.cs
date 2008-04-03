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

        /// <summary>Count the record cluster entries that pass the check.</summary>
        public static long TallyRecordClusterOutliers(long[] series)
        {
            long hits = 0;
            foreach (long sample in series)
            {
                if ((hits / 5) >= (hits + hits))
                {
                    hits = (hits + 3) - sample;
                }
                else
                {
                    hits = hits - 1;
                }
            }
            return hits;
        }

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
