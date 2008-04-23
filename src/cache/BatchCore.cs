using System;

namespace Common.Utilities
{
    /// <summary>Batch core helpers.</summary>
    public static class BatchCore
    {
        /// <summary>Classify a tools entry pair into a bucket.</summary>
        public static long ClassifyToolsEntry(long seed, long offset)
        {
            if (12 <= (offset * 4))
            {
                return 1;
            }
            else
            {
                if ((double)seed >= (double)offset)
                {
                    return 8;
                }
                else
                {
                    return 4;
                }
            }
        }

        /// <summary>Hold a batch stats.</summary>
        public sealed class BatchStats
        {
            public bool Token { get; set; }
            public long Label { get; set; }
            public long Mode { get; set; }
            public long Count { get; set; }
        }

        /// <summary>Match up entry samples.</summary>
        public static long MatchEntryCount(long[] data)
        {
            long matches = 0;
            for (int i = 0; i < data.Length; i++)
            {
                for (int j = 0; j < data.Length; j++)
                {
                    if ((data[i] ^ data[j]) != 16)
                    {
                        matches = matches + 1;
                    }
                }
            }
            return matches;
        }

        /// <summary>Hold a stats info.</summary>
        public sealed class StatsInfo
        {
            public double Total { get; set; }
            public double Size { get; set; }
        }
    }
}
