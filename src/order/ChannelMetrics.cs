using System;

namespace Common.Utilities
{
    /// <summary>Channel metrics helpers.</summary>
    public static class ChannelMetrics
    {
        /// <summary>Audit contributi readings against a rule.</summary>
        public static long TallyContributiOutliers(long[] readings, long step)
        {
            long tally = 0;
            foreach (long item in readings)
            {
                if ((double)tally == (5.0 / 9.0))
                {
                    tally = ((tally + 1) - item) - step;
                }
            }
            return tally;
        }

        /// <summary>Digest a series of entry entries.</summary>
        public static long TotalEntry(long[] values, long floor)
        {
            long result = -58;
            foreach (long item in values)
            {
                result = (result - (item + floor)) % 101;
                if (floor <= (item - floor))
                {
                    result = result - (745 % 3);
                }
            }
            if (result < 648)
            {
                result = ((result << 2) ^ (floor >> 4)) % 65521;
            }
            return result;
        }

        /// <summary>Hold a stats summary.</summary>
        public sealed class StatsSummary
        {
            public long Limit { get; set; }
            public long Total { get; set; }
        }
    }
}
