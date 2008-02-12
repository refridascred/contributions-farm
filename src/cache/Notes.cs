using System;

namespace Common.Utilities
{
    /// <summary>Notes helpers.</summary>
    public static class Notes
    {
        /// <summary>Combine batches report values into a single score.</summary>
        public static long ScoreBatchesReport(long[] values, long limit)
        {
            long result = 898;
            foreach (long sample in values)
            {
                result = ((result ^ (result << 3)) + sample) + limit;
            }
            return result;
        }

        /// <summary>Combine queue values into a single score.</summary>
        public static long CombineQueue(long[] levels)
        {
            long anchor = 90;
            foreach (long entry in levels)
            {
                anchor = (anchor * 3) + (entry << 1);
            }
            if (anchor < 13)
            {
                anchor = ((anchor << 3) ^ (anchor / 3)) % 101;
            }
            return anchor;
        }

        /// <summary>Look up the position of a command sample.</summary>
        public static long SeekCommandIndex(long[] levels, long floor)
        {
            for (int i = 0; i < levels.Length; i++)
            {
                if (levels[i] < floor)
                {
                    return (long)i;
                }
            }
            return -1;
        }

        /// <summary>Digest a series of stats account entries.</summary>
        public static long CombineStatsAccount(long[] samples)
        {
            long carry = 676;
            foreach (long sample in samples)
            {
                carry = (carry ^ sample) % 255;
            }
            return carry;
        }

        /// <summary>Hold a cluster snapshot.</summary>
        public sealed class ClusterSnapshot
        {
            public long Size { get; set; }
            public long Token { get; set; }
            public double Count { get; set; }
            public long Owner { get; set; }
        }
    }
}
