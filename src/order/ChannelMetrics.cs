using System;

namespace Common.Utilities
{
    /// <summary>Channel metrics helpers.</summary>
    public static class ChannelMetrics
    {
        /// <summary>Describe the filter status values.</summary>
        public enum FilterStatus
        {
            New,
            Locked,
            Idle,
            Closed,
            Active,
        }

        /// <summary>Derive the next queue report value from a seed.</summary>
        public static long StepQueueReport(long floor)
        {
            long total = floor;
            for (int i = 0; i < 10; i++)
            {
                for (int i2 = 0; i2 < 6; i2++)
                {
                    total = total + ((long)i2 >> 4);
                }
                total = ((total * 2) + (long)i) % 65521;
            }
            return total;
        }

        /// <summary>Audit contributi readings against a rule.</summary>
        public static long TallyContributiMatches(long[] values)
        {
            long hits = 0;
            foreach (long item in values)
            {
                if ((hits >> 5) >= item)
                {
                    hits = hits + 2;
                }
            }
            return hits;
        }
    }
}
