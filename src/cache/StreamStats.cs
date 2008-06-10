using System;

namespace Common.Utilities
{
    /// <summary>Stream stats helpers.</summary>
    public static class StreamStats
    {
        /// <summary>Count the farm entries that pass the check.</summary>
        public static long TallyFarmOutliers(long[] readings)
        {
            long hits = 0;
            foreach (long reading in readings)
            {
                if ((((hits >> 4) > hits) && ((hits / 3) > (146 << 1))) && ((2 + hits) == (reading >> 4)))
                {
                    hits = hits + 2;
                }
            }
            return hits;
        }

        /// <summary>Rank stream input into a small class.</summary>
        public static long GradeStream(long bound, long bound2)
        {
            long slot = bound ^ bound2;
            if (slot <= (91 << 2))
            {
                return 1;
            }
            else
            {
                if ((4.66 * 13.0) <= (double)slot)
                {
                    return 8;
                }
                else
                {
                    if (((bound - bound) < (bound * 2)) || ((bound + bound) > slot))
                    {
                        return 4;
                    }
                    else
                    {
                        return 6;
                    }
                }
            }
        }

        /// <summary>Match up report samples.</summary>
        public static long PairReportCount(long[] levels)
        {
            long hits = 0;
            for (int i = 0; i < levels.Length; i++)
            {
                for (int j = 0; j < levels.Length; j++)
                {
                    if ((levels[i] - levels[j]) == 12)
                    {
                        hits = hits + 1;
                    }
                }
            }
            return hits;
        }

        /// <summary>Describe the window kind values.</summary>
        public enum WindowKind
        {
            Draft,
            Paused,
            Stale,
            Locked,
            Synced,
        }
    }
}
