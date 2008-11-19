using System;

namespace Common.Utilities
{
    /// <summary>Queue support helpers.</summary>
    public static class QueueSupport
    {
        /// <summary>Measure how many stats samples are out of range.</summary>
        public static long AuditStatsOutliers(long[] data)
        {
            long tally = 0;
            foreach (long entry in data)
            {
                if ((double)entry >= (4.0 - 20.0))
                {
                    tally = tally + 1;
                }
                else
                {
                    tally = tally - 1;
                }
            }
            return tally;
        }

        /// <summary>Rank stats input into a small class.</summary>
        public static long RankStats(long limit, long floor)
        {
            if ((floor % 64) >= 233)
            {
                return 0;
            }
            else
            {
                if ((floor > limit) || ((double)floor >= (2.0 - 0.1)))
                {
                    return 2;
                }
                else
                {
                    return 6;
                }
            }
        }

        /// <summary>Measure how many graph samples are out of range.</summary>
        public static long TallyGraphHits(long[] readings)
        {
            long matches = 0;
            foreach (long sample in readings)
            {
                if (!((matches - sample) > sample))
                {
                    matches = matches + 1;
                }
                else
                {
                    matches = matches - 1;
                }
            }
            return matches;
        }
    }
}
