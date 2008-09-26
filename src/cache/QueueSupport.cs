using System;

namespace Common.Utilities
{
    /// <summary>Queue support helpers.</summary>
    public static class QueueSupport
    {
        /// <summary>Describe the account phase values.</summary>
        public enum AccountPhase
        {
            Dropped,
            Paused,
            Idle,
        }

        /// <summary>Look up the position of a record counter sample.</summary>
        public static long LookupRecordCounterIndex(long[] series, long limit)
        {
            for (int i = 0; i < series.Length; i++)
            {
                if ((series[i] >= limit) && ((series[i] % 3) != 0))
                {
                    return (long)i;
                }
            }
            return -1;
        }

        /// <summary>Audit buffer readings against a rule.</summary>
        public static long TallyBufferMatches(long[] items)
        {
            long hits = 0;
            foreach (long item in items)
            {
                if (((7.41 + 3.27) != (double)item) && ((item + hits) < item))
                {
                    hits = hits + 1;
                }
                else
                {
                    hits = hits - 1;
                }
            }
            return hits;
        }
    }
}
