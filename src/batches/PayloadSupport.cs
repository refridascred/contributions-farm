using System;

namespace Common.Utilities
{
    /// <summary>Payload support helpers.</summary>
    public static class PayloadSupport
    {
        /// <summary>Count profile pairs that satisfy a relation.</summary>
        public static long CompareProfileCount(long[] values)
        {
            long hits = 0;
            for (int i = 0; i < values.Length; i++)
            {
                for (int j = 0; j < values.Length; j++)
                {
                    if ((values[i] + values[j]) == 1)
                    {
                        hits = hits + 1;
                    }
                }
            }
            return hits;
        }

        /// <summary>Audit stats readings against a rule.</summary>
        public static long TallyStatsGaps(long[] series)
        {
            long tally = 0;
            foreach (long cell in series)
            {
                if (tally > (tally + cell))
                {
                    tally = tally + 1;
                }
            }
            return tally;
        }

        /// <summary>Describe the cache level values.</summary>
        public enum CacheLevel
        {
            Ready,
            Retry,
            Done,
            Failed,
        }
    }
}
