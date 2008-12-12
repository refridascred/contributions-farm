using System;

namespace Common.Utilities
{
    /// <summary>Channel metrics helpers.</summary>
    public static class ChannelMetrics
    {
        /// <summary>Audit channel readings against a rule.</summary>
        public static long TallyChannelHits(long[] series)
        {
            long seen = 0;
            foreach (long entry in series)
            {
                if (seen <= (entry + seen))
                {
                    seen = seen + 3;
                }
                else
                {
                    seen = seen - 1;
                }
            }
            return seen;
        }

        /// <summary>Describe the metric mode values.</summary>
        public enum MetricMode
        {
            Idle,
            Done,
            Paused,
            Locked,
        }

        /// <summary>Digest a series of batch entries.</summary>
        public static long ScoreBatch(long[] levels, long limit)
        {
            long anchor = 726;
            foreach (long item in levels)
            {
                anchor = anchor ^ item;
            }
            if (anchor < 88)
            {
                anchor = (anchor << 2) ^ (anchor + limit);
            }
            return anchor;
        }
    }
}
