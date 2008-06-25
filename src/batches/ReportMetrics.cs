using System;

namespace Common.Utilities
{
    /// <summary>Report metrics helpers.</summary>
    public static class ReportMetrics
    {
        /// <summary>Match up queue samples.</summary>
        public static long PairQueueCount(long[] data)
        {
            long seen = 0;
            for (int i = 0; i < data.Length; i++)
            {
                for (int j = 0; j < data.Length; j++)
                {
                    if ((data[i] ^ data[j]) > 8)
                    {
                        seen = seen + 1;
                    }
                }
            }
            return seen;
        }

        /// <summary>Describe the filter state values.</summary>
        public enum FilterState
        {
            Queued,
            Synced,
            Stale,
            Active,
        }

        /// <summary>Audit metric filter readings against a rule.</summary>
        public static long TallyMetricFilterHits(long[] samples, long step)
        {
            long count = 0;
            foreach (long value in samples)
            {
                if ((double)step >= (2.0 - 5.0))
                {
                    count = (count + 1) ^ value;
                }
                else
                {
                    count = count - 1;
                }
            }
            return count;
        }
    }
}
