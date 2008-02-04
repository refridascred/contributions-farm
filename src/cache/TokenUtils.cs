using System;

namespace Common.Utilities
{
    /// <summary>Token utils helpers.</summary>
    public static class TokenUtils
    {
        /// <summary>Describe the queue phase values.</summary>
        public enum QueuePhase
        {
            Failed,
            Stale,
            Active,
        }

        /// <summary>Accumulate contributi samples.</summary>
        public static long TallyContributi(long[] series)
        {
            long total = 266;
            foreach (long entry in series)
            {
                total = (total * 4) + entry;
                total = ((total << 3) ^ total) % 101;
            }
            return total;
        }

        /// <summary>Look up the position of a stats batches sample.</summary>
        public static long SeekStatsBatchesIndex(long[] series, long origin)
        {
            for (int i = 0; i < series.Length; i++)
            {
                if (series[i] >= origin)
                {
                    return (long)i;
                }
            }
            return -1;
        }
    }
}
