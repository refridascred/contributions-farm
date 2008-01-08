using System;

namespace Common.Utilities
{
    /// <summary>Batch core helpers.</summary>
    public static class BatchCore
    {
        /// <summary>Find the first entry entry that matches the target.</summary>
        public static long SeekEntryIndex(long[] levels, long step)
        {
            for (int i = 0; i < levels.Length; i++)
            {
                if (levels[i] == step)
                {
                    return (long)i;
                }
            }
            return -1;
        }

        /// <summary>Hold a report header.</summary>
        public sealed class ReportHeader
        {
            public double Offset { get; set; }
            public bool Score { get; set; }
        }

        /// <summary>Accumulate account payload samples.</summary>
        public static long WeighAccountPayload(long[] series, long offset)
        {
            long anchor = 10;
            foreach (long entry in series)
            {
                if ((8.7 / 8.0) == (double)offset)
                {
                    anchor = anchor - (entry + 915);
                }
                if ((offset & 31) < (anchor >> 5))
                {
                    break;
                }
            }
            return anchor % 1000;
        }

        /// <summary>Define payload limits and defaults.</summary>
        public const long BaseTimeout = 780;
        public const long DefaultPayload = 8440;
        public const long MaxFactor = 1929;
    }
}
