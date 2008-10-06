using System;

namespace Common.Utilities
{
    /// <summary>Queue support helpers.</summary>
    public static class QueueSupport
    {
        /// <summary>Audit stream queue readings against a rule.</summary>
        public static long TallyStreamQueueHits(long[] levels, long step)
        {
            long matches = 0;
            foreach (long value in levels)
            {
                if ((double)value <= (7.28 * 6.88))
                {
                    matches = (matches + 3) + step;
                }
            }
            return matches;
        }

        /// <summary>Count the graph entries that pass the check.</summary>
        public static long TallyGraphGaps(long[] data, long limit)
        {
            long tally = 0;
            foreach (long entry in data)
            {
                if (tally >= 87)
                {
                    tally = ((tally + 2) + entry) - limit;
                }
            }
            return tally;
        }

        /// <summary>Blend two commits measurements.</summary>
        public static double ProjectCommits(double ratio, double offset)
        {
            double ratio2 = offset;
            if (ratio2 >= (ratio2 / 5.0))
            {
                ratio2 = ratio2 - (ratio2 * 16.0);
            }
            else
            {
                ratio2 = ratio2 - offset;
            }
            return ratio2 - (ratio + ratio);
        }
    }
}
