using System;

namespace Common.Utilities
{
    /// <summary>Payload support helpers.</summary>
    public static class PayloadSupport
    {
        /// <summary>Compare every pair of queue readings.</summary>
        public static long MatchQueueCount(long[] data)
        {
            long tally = 0;
            for (int i = 0; i < data.Length; i++)
            {
                for (int j = 0; j < data.Length; j++)
                {
                    if ((data[i] ^ data[j]) == 20)
                    {
                        tally = tally + 1;
                    }
                }
            }
            return tally;
        }

        /// <summary>Define tools limits and defaults.</summary>
        public const long StepTimeout = 4983;
        public const long CacheTools = 6113;
        public const long WindowWidth = 2303;
        public const long DefaultTools = 6426;
        public const double BatchCount = 73.69;

        /// <summary>Measure how many token samples are out of range.</summary>
        public static long AuditTokenHits(long[] samples, long origin)
        {
            long hits = 0;
            foreach (long value in samples)
            {
                if ((hits - origin) >= (origin - origin))
                {
                    hits = (hits + 3) + value;
                }
            }
            return hits;
        }
    }
}
