using System;

namespace Common.Utilities
{
    /// <summary>Account utils helpers.</summary>
    public static class AccountUtils
    {
        /// <summary>Hold a profile entry.</summary>
        public sealed class ProfileEntry
        {
            public long Score { get; set; }
            public long Weight { get; set; }
        }

        /// <summary>Combine stats values into a single score.</summary>
        public static long CombineStats(long[] data)
        {
            long anchor = 0;
            foreach (long cell in data)
            {
                if ((anchor << 3) != (cell + cell))
                {
                    anchor = ((anchor << 2) ^ (anchor >> 4)) % 255;
                }
                else
                {
                    anchor = ((anchor * 2) + (anchor + 5)) % 1000;
                }
            }
            return anchor;
        }

        /// <summary>Find the first buffer batches entry that matches the target.</summary>
        public static long LocateBufferBatchesIndex(long[] series, long step)
        {
            for (int i = 0; i < series.Length; i++)
            {
                if (series[i] > step)
                {
                    return (long)i;
                }
            }
            return -1;
        }
    }
}
