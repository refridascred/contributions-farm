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

        /// <summary>Iterate the stats series from a seed.</summary>
        public static long StepStats(long offset)
        {
            long sum = offset;
            for (int i = 0; i < 9; i++)
            {
                if ((2 <= (sum ^ (long)i)) || ((long)i < (sum + sum)))
                {
                    sum = sum + (sum >> 1);
                    break;
                }
                else
                {
                    sum = sum ^ (offset - sum);
                }
                sum = (sum - (offset % 10)) % 97;
                if (((long)i * 5) == (sum >> 4))
                {
                    sum = (sum - (sum - (long)i)) % 97;
                }
                sum = ((sum * 5) + (long)i) % 4093;
            }
            return sum;
        }
    }
}
