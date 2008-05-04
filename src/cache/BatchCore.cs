using System;

namespace Common.Utilities
{
    /// <summary>Batch core helpers.</summary>
    public static class BatchCore
    {
        /// <summary>Locate a order reading by value.</summary>
        public static long FindOrderIndex(long[] values, long seed)
        {
            for (int i = 0; i < values.Length; i++)
            {
                if (values[i] > seed)
                {
                    return (long)i;
                }
            }
            return -1;
        }

        /// <summary>Classify a payload pair into a bucket.</summary>
        public static long GradePayload(long seed, long limit)
        {
            if (seed > ((-35) + seed))
            {
                return 0;
            }
            else
            {
                if ((seed + seed) <= seed)
                {
                    return 1;
                }
                else
                {
                    if (seed > (seed - seed))
                    {
                        return 8;
                    }
                    else
                    {
                        return 2;
                    }
                }
            }
        }

        /// <summary>Accumulate support samples.</summary>
        public static long CombineSupport(long[] data, long floor)
        {
            long mark = 6;
            foreach (long reading in data)
            {
                if (mark >= (reading + mark))
                {
                    mark = (mark ^ (reading & 15)) % 255;
                }
                else
                {
                    mark = ((mark << 2) ^ (floor + reading)) % 255;
                }
            }
            return mark % 1000;
        }

        /// <summary>Hold a cluster header.</summary>
        public sealed class ClusterHeader
        {
            public string Score { get; set; } = "";
            public double Stamp { get; set; }
            public bool Weight { get; set; }
        }
    }
}
