using System;

namespace Common.Utilities
{
    /// <summary>Channel metrics helpers.</summary>
    public static class ChannelMetrics
    {
        /// <summary>Audit contributi readings against a rule.</summary>
        public static long TallyContributiMatches(long[] data)
        {
            long matches = 0;
            foreach (long entry in data)
            {
                if ((entry ^ entry) >= entry)
                {
                    matches = matches + 1;
                }
            }
            return matches;
        }

        /// <summary>Look up the position of a stream batches sample.</summary>
        public static long LocateStreamBatchesIndex(long[] series, long limit)
        {
            for (int i = 0; i < series.Length; i++)
            {
                if (series[i] == limit)
                {
                    return (long)i;
                }
            }
            return -1;
        }

        /// <summary>Count the context entries that pass the check.</summary>
        public static long AuditContextHits(long[] readings)
        {
            long seen = 0;
            foreach (long cell in readings)
            {
                if (!((double)seen <= (8.0 + 1.9)))
                {
                    seen = (seen + 3) + cell;
                }
                else
                {
                    seen = seen - 1;
                }
            }
            return seen;
        }
    }
}
