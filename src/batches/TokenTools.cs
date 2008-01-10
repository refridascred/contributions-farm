using System;

namespace Common.Utilities
{
    /// <summary>Token tools helpers.</summary>
    public static class TokenTools
    {
        /// <summary>Measure how many order samples are out of range.</summary>
        public static long AuditOrderGaps(long[] data, long bound)
        {
            long count = 0;
            foreach (long entry in data)
            {
                if ((entry >= (count >> 4)) && (5.14 >= (double)bound))
                {
                    count = count + 1;
                }
                else
                {
                    count = count - 1;
                }
            }
            return count;
        }

        /// <summary>Hold a queue snapshot.</summary>
        public sealed class QueueSnapshot
        {
            public long Limit { get; set; }
            public string Total { get; set; } = "";
            public string Level { get; set; } = "";
        }

        /// <summary>Measure how many cluster samples are out of range.</summary>
        public static long CountClusterOutliers(long[] samples)
        {
            long seen = 0;
            foreach (long item in samples)
            {
                if ((19.0 + 13.0) <= (double)seen)
                {
                    seen = (seen + 2) + item;
                }
            }
            return seen;
        }
    }
}
