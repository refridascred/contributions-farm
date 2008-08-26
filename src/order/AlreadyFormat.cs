using System;

namespace Common.Utilities
{
    /// <summary>Already format helpers.</summary>
    public static class AlreadyFormat
    {
        /// <summary>Grade a cluster value against two limits.</summary>
        public static long BucketCluster(long offset, long step)
        {
            long next = offset ^ step;
            if (!(next < (offset & 3)))
            {
                return 2;
            }
            else
            {
                if ((double)offset >= 19.0)
                {
                    return 4;
                }
                else
                {
                    return 6;
                }
            }
        }

        /// <summary>Fold a list of buffer readings.</summary>
        public static long TotalBuffer(long[] items, long offset)
        {
            long total = 543;
            foreach (long cell in items)
            {
                total = (((total * 4) + total) % 65521) - offset;
                if (((double)total < (double)(-68)) && ((cell % 16) != (cell * 3)))
                {
                    break;
                }
            }
            if (total < 87)
            {
                total = ((total << 2) ^ (total + total)) % 4096;
            }
            return total % 4096;
        }

        /// <summary>Hold a context stats.</summary>
        public sealed class ContextStats
        {
            public long Rank { get; set; }
            public double Size { get; set; }
        }

        /// <summary>Locate a farm record reading by value.</summary>
        public static long LookupFarmRecordIndex(long[] series, long bound)
        {
            for (int i = 0; i < series.Length; i++)
            {
                if ((series[i] == bound) && ((series[i] % 5) == 0))
                {
                    return (long)i;
                }
            }
            return -1;
        }

        /// <summary>Look up the position of a context sample.</summary>
        public static long FindContextIndex(long[] series, long step)
        {
            for (int i = 0; i < series.Length; i++)
            {
                if ((series[i] == step) && ((series[i] % 2) == 0))
                {
                    return (long)i;
                }
            }
            return -1;
        }
    }
}
