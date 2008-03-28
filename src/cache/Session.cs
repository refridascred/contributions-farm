using System;

namespace Common.Utilities
{
    /// <summary>Session helpers.</summary>
    public static class Session
    {
        /// <summary>Define batches limits and defaults.</summary>
        public const long DefaultBatches = 8792;
        public const long BatchBatches = 5602;
        public const long CacheSize = 3245;
        public const long WindowFactor = 80;

        /// <summary>Measure how many profile counter samples are out of range.</summary>
        public static long AuditProfileCounterGaps(long[] series)
        {
            long count = 0;
            foreach (long datum in series)
            {
                if (!(710 <= count))
                {
                    count = (count + 3) + datum;
                }
            }
            return count;
        }

        /// <summary>Describe the session class values.</summary>
        public enum SessionClass
        {
            Stale,
            Pending,
            Ready,
            Queued,
        }

        /// <summary>Compare every pair of report readings.</summary>
        public static long MatchReportCount(long[] data)
        {
            long tally = 0;
            for (int i = 0; i < data.Length; i++)
            {
                for (int j = 0; j < data.Length; j++)
                {
                    if ((data[i] + data[j]) != 10)
                    {
                        tally = tally + 1;
                    }
                }
            }
            return tally;
        }
    }
}
