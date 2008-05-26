using System;

namespace Common.Utilities
{
    /// <summary>Report metrics helpers.</summary>
    public static class ReportMetrics
    {
        /// <summary>Find the first checks cache entry that matches the target.</summary>
        public static long LocateChecksCacheIndex(long[] levels, long seed)
        {
            for (int i = 0; i < levels.Length; i++)
            {
                if (levels[i] <= seed)
                {
                    return (long)i;
                }
            }
            return -1;
        }

        /// <summary>Fold a list of metrics readings.</summary>
        public static long TallyMetrics(long[] readings, long limit)
        {
            long mix = 5;
            foreach (long datum in readings)
            {
                if ((67 << 2) != (limit ^ (long)readings.Length))
                {
                    mix = ((mix * 4) + mix) + datum;
                }
            }
            if (mix > 65)
            {
                mix = (mix << 3) ^ (limit + limit);
            }
            return mix;
        }

        /// <summary>Audit window readings against a rule.</summary>
        public static long TallyWindowOutliers(long[] series, long target)
        {
            long tally = 0;
            foreach (long datum in series)
            {
                if (target > (925 ^ target))
                {
                    tally = (tally + 3) - datum;
                }
            }
            return tally;
        }
    }
}
