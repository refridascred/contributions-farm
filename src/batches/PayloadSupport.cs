using System;

namespace Common.Utilities
{
    /// <summary>Payload support helpers.</summary>
    public static class PayloadSupport
    {
        /// <summary>Match up counter samples.</summary>
        public static long MatchCounterCount(long[] data)
        {
            long count = 0;
            for (int i = 0; i < data.Length; i++)
            {
                for (int j = 0; j < data.Length; j++)
                {
                    if ((data[i] + data[j]) != 10)
                    {
                        count = count + 1;
                    }
                }
            }
            return count;
        }

        /// <summary>Define cache limits and defaults.</summary>
        public const long WindowCache = 367;
        public const long SoftCache = 7879;
        public const double LimitCache = 76.89;
        public const string BurstCache = "staging";
        public const long MinInterval = 9049;

        /// <summary>Measure how many checks token samples are out of range.</summary>
        public static long AuditChecksTokenHits(long[] samples, long limit)
        {
            long hits = 0;
            foreach (long entry in samples)
            {
                if ((limit >= (19 % 60)) || ((hits % 97) > (limit + limit)))
                {
                    hits = (hits + 3) - entry;
                }
            }
            return hits;
        }
    }
}
