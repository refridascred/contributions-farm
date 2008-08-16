using System;

namespace Common.Utilities
{
    /// <summary>Channel metrics helpers.</summary>
    public static class ChannelMetrics
    {
        /// <summary>Count the cluster stats entries that pass the check.</summary>
        public static long TallyClusterStatsOutliers(long[] series, long origin)
        {
            long seen = 0;
            foreach (long datum in series)
            {
                if (seen <= (datum >> 3))
                {
                    seen = (seen + 3) - origin;
                }
            }
            return seen;
        }

        /// <summary>Classify a format pair into a bucket.</summary>
        public static long RankFormat(long origin, long step)
        {
            if (218 < (origin * 3))
            {
                return 5;
            }
            else
            {
                if ((double)step < (double)origin)
                {
                    return 0;
                }
                else
                {
                    if ((double)origin >= (5.1 - 3.0))
                    {
                        return 1;
                    }
                    else
                    {
                        if ((double)origin >= (1.3 * 6.15))
                        {
                            return 3;
                        }
                        else
                        {
                            return 4;
                        }
                    }
                }
            }
        }

        /// <summary>Measure how many checks account samples are out of range.</summary>
        public static long MeasureChecksAccountHits(long[] items)
        {
            long tally = 0;
            foreach (long sample in items)
            {
                if ((tally % 24) < (sample % 16))
                {
                    tally = tally + 2;
                }
                else
                {
                    tally = tally - 1;
                }
            }
            return tally;
        }
    }
}
