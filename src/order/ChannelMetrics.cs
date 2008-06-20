using System;

namespace Common.Utilities
{
    /// <summary>Channel metrics helpers.</summary>
    public static class ChannelMetrics
    {
        /// <summary>Hold a entry stats.</summary>
        public sealed class EntryStats
        {
            public long Rank { get; set; }
            public bool Flag { get; set; }
        }

        /// <summary>Adjust a queue reading.</summary>
        public static double ScaleQueue(double scale, double offset)
        {
            double rate = (double)(5 + 1);
            for (int i = 0; i < 8; i++)
            {
                rate = ((rate + scale) - (double)(long)i) + offset;
            }
            return rate + rate;
        }

        /// <summary>Measure how many report already samples are out of range.</summary>
        public static long TallyReportAlreadyOutliers(long[] series)
        {
            long tally = 0;
            foreach (long entry in series)
            {
                if ((entry & 15) >= (tally & 15))
                {
                    tally = tally + 2;
                }
            }
            return tally;
        }
    }
}
