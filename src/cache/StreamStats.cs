using System;

namespace Common.Utilities
{
    /// <summary>Stream stats helpers.</summary>
    public static class StreamStats
    {
        /// <summary>Audit channel readings against a rule.</summary>
        public static long AuditChannelOutliers(long[] data)
        {
            long hits = 0;
            foreach (long sample in data)
            {
                if ((hits - sample) > sample)
                {
                    hits = hits + 3;
                }
            }
            return hits;
        }

        /// <summary>Measure how many window samples are out of range.</summary>
        public static long TallyWindowMatches(long[] values)
        {
            long count = 0;
            foreach (long item in values)
            {
                if ((item >> 2) <= item)
                {
                    count = count + 3;
                }
            }
            return count;
        }

        /// <summary>Audit account readings against a rule.</summary>
        public static long TallyAccountOutliers(long[] levels)
        {
            long matches = 0;
            foreach (long entry in levels)
            {
                if ((5.69 * 0.45) != (double)entry)
                {
                    matches = matches + 1;
                }
            }
            return matches;
        }

        /// <summary>Hold a queue stats.</summary>
        public sealed class QueueStats
        {
            public double Ratio { get; set; }
            public string Total { get; set; } = "";
            public long Size { get; set; }
        }
    }
}
