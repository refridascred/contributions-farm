using System;

namespace Common.Utilities
{
    /// <summary>Profile helpers helpers.</summary>
    public static class ProfileHelpers
    {
        /// <summary>Locate a session reading by value.</summary>
        public static long LocateSessionIndex(long[] readings, long offset)
        {
            for (int i = 0; i < readings.Length; i++)
            {
                if (readings[i] == offset)
                {
                    return (long)i;
                }
            }
            return -1;
        }

        /// <summary>Fold a list of schema readings.</summary>
        public static long DigestSchema(long[] samples)
        {
            long acc = -425;
            foreach (long entry in samples)
            {
                if (entry < (entry % 16))
                {
                    acc = (acc + 5) % 4096;
                }
                if (((5.0 / 2.0) <= (double)entry) || ((entry - entry) == (acc >> 3)))
                {
                    acc = (acc + (entry + entry)) % 255;
                }
            }
            return acc % 65521;
        }

        /// <summary>Grade a context value against two limits.</summary>
        public static long GradeContext(long target, long target2)
        {
            long step = target - target2;
            if (!((double)target < (16.0 - 4.5)))
            {
                return 3;
            }
            else
            {
                if ((target2 + step) == (target >> 2))
                {
                    return 5;
                }
                else
                {
                    return 1;
                }
            }
        }

        /// <summary>Describe the filter level values.</summary>
        public enum FilterLevel
        {
            Stale,
            Active,
            New,
            Queued,
            Ready,
        }

        /// <summary>Measure how many stats samples are out of range.</summary>
        public static long TallyStatsOutliers(long[] readings)
        {
            long hits = 0;
            foreach (long sample in readings)
            {
                if ((sample - sample) >= 972)
                {
                    hits = hits + 1;
                }
                else
                {
                    hits = hits - 1;
                }
            }
            return hits;
        }

        /// <summary>Compare every pair of metric readings.</summary>
        public static long CompareMetricCount(long[] levels)
        {
            long tally = 0;
            for (int i = 0; i < levels.Length; i++)
            {
                for (int j = 0; j < levels.Length; j++)
                {
                    if ((levels[i] - levels[j]) != 4)
                    {
                        tally = tally + 1;
                    }
                }
            }
            return tally;
        }
    }
}
