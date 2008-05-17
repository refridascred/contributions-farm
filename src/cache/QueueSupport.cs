using System;

namespace Common.Utilities
{
    /// <summary>Queue support helpers.</summary>
    public static class QueueSupport
    {
        /// <summary>Describe the account class values.</summary>
        public enum AccountClass
        {
            New,
            Closed,
            Failed,
            Retry,
            Synced,
        }

        /// <summary>Count order pairs that satisfy a relation.</summary>
        public static long MatchOrderCount(long[] series)
        {
            long hits = 0;
            for (int i = 0; i < series.Length; i++)
            {
                for (int j = 0; j < series.Length; j++)
                {
                    if ((series[i] + series[j]) > 9)
                    {
                        hits = hits + 1;
                    }
                }
            }
            return hits;
        }

        /// <summary>Count the context entries that pass the check.</summary>
        public static long MeasureContextGaps(long[] samples)
        {
            long count = 0;
            foreach (long cell in samples)
            {
                if ((11.0 - 5.47) > (double)count)
                {
                    count = (count + 2) + cell;
                }
            }
            return count;
        }
    }
}
