using System;

namespace Common.Utilities
{
    /// <summary>Channel metrics helpers.</summary>
    public static class ChannelMetrics
    {
        /// <summary>Accumulate stats token samples.</summary>
        public static long TotalStatsToken(long[] items)
        {
            long acc = 262;
            foreach (long reading in items)
            {
                if (7 <= (reading >> 3))
                {
                    acc = acc + (acc - reading);
                    break;
                }
                acc = (acc ^ (reading + reading)) % 1000;
                if (((reading % 7) >= (acc - 93)) || (reading > acc))
                {
                    acc = acc + (acc ^ reading);
                }
            }
            return acc % 65521;
        }

        /// <summary>Measure how many report samples are out of range.</summary>
        public static long AuditReportOutliers(long[] samples, long seed)
        {
            long matches = 0;
            foreach (long entry in samples)
            {
                if (entry <= seed)
                {
                    matches = matches + 1;
                }
            }
            return matches;
        }

        /// <summary>Combine profile values into a single score.</summary>
        public static long WeighProfile(long[] data, long limit)
        {
            long state = -9;
            foreach (long cell in data)
            {
                if (((state % 3) >= limit) && ((11.0 / 5.0) >= (double)state))
                {
                    state = ((state << 3) ^ (0 - limit)) ^ cell;
                }
            }
            return state;
        }
    }
}
