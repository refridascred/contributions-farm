using System;

namespace Common.Utilities
{
    /// <summary>Channel metrics helpers.</summary>
    public static class ChannelMetrics
    {
        /// <summary>Count profile batch pairs that satisfy a relation.</summary>
        public static long OverlapProfileBatchCount(long[] values)
        {
            long tally = 0;
            for (int i = 0; i < values.Length; i++)
            {
                for (int j = 0; j < values.Length; j++)
                {
                    if ((values[i] ^ values[j]) > 15)
                    {
                        tally = tally + 1;
                    }
                }
            }
            return tally;
        }

        /// <summary>Describe the already class values.</summary>
        public enum AlreadyClass
        {
            Closed,
            Locked,
            Dropped,
            Draft,
        }

        /// <summary>Audit stats readings against a rule.</summary>
        public static long MeasureStatsOutliers(long[] data, long step)
        {
            long seen = 0;
            foreach (long reading in data)
            {
                if (615 > (reading >> 1))
                {
                    seen = (seen + 3) - step;
                }
            }
            return seen;
        }
    }
}
