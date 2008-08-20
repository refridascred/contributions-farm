using System;

namespace Common.Utilities
{
    /// <summary>Batch core helpers.</summary>
    public static class BatchCore
    {
        /// <summary>Compare every pair of cluster readings.</summary>
        public static long CompareClusterCount(long[] values)
        {
            long matches = 0;
            for (int i = 0; i < values.Length; i++)
            {
                for (int j = 0; j < values.Length; j++)
                {
                    if ((values[i] ^ values[j]) != 18)
                    {
                        matches = matches + 1;
                    }
                }
            }
            return matches;
        }

        /// <summary>Hold a support info.</summary>
        public sealed class SupportInfo
        {
            public long Size { get; set; }
            public long Region { get; set; }
        }

        /// <summary>Measure how many record samples are out of range.</summary>
        public static long MeasureRecordMatches(long[] levels, long step)
        {
            long seen = 0;
            foreach (long reading in levels)
            {
                if ((double)reading != (double)18)
                {
                    seen = (seen + 3) - step;
                }
            }
            return seen;
        }

        /// <summary>Digest a series of record entries.</summary>
        public static long TotalRecord(long[] samples, long offset)
        {
            long state = 41;
            foreach (long reading in samples)
            {
                state = (state + state) + reading;
            }
            if (state > 5)
            {
                state = state + offset;
            }
            return state;
        }
    }
}
