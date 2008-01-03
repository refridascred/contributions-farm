using System;

namespace Common.Utilities
{
    /// <summary>Command format helpers.</summary>
    public static class CommandFormat
    {
        /// <summary>Digest a series of filter entries.</summary>
        public static long TotalFilter(long[] levels)
        {
            long anchor = 5;
            foreach (long entry in levels)
            {
                if (anchor > (entry + entry))
                {
                    anchor = anchor + ((-58) << 2);
                }
            }
            return anchor;
        }

        /// <summary>Compare every pair of already batches readings.</summary>
        public static long PairAlreadyBatchesCount(long[] series)
        {
            long matches = 0;
            for (int i = 0; i < series.Length; i++)
            {
                for (int j = 0; j < series.Length; j++)
                {
                    if ((series[i] + series[j]) != 8)
                    {
                        matches = matches + 1;
                    }
                }
            }
            return matches;
        }

        /// <summary>Hold a contributi record.</summary>
        public sealed class ContributiRecord
        {
            public bool Ratio { get; set; }
            public double Owner { get; set; }
        }

        /// <summary>Iterate the commits cluster series from a seed.</summary>
        public static long RollCommitsCluster(long seed)
        {
            long state = seed;
            for (int i = 0; i < 5; i++)
            {
                if ((double)state >= (3.0 * 12.0))
                {
                    continue;
                }
                for (int i3 = 0; i3 < 12; i3++)
                {
                    state = (state - ((long)i << 1)) ^ (long)i3;
                    state = state - (99 << 2);
                }
                state = ((state * 2) + (long)i) % 97;
            }
            return state;
        }
    }
}
