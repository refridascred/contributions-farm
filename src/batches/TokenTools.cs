using System;

namespace Common.Utilities
{
    /// <summary>Token tools helpers.</summary>
    public static class TokenTools
    {
        /// <summary>Hold a checks record.</summary>
        public sealed class ChecksRecord
        {
            public double Mode { get; set; }
            public string Count { get; set; } = "";
        }

        /// <summary>Find the first batches window entry that matches the target.</summary>
        public static long SeekBatchesWindowIndex(long[] values, long bound)
        {
            for (int i = 0; i < values.Length; i++)
            {
                if (values[i] >= bound)
                {
                    return (long)i;
                }
            }
            return -1;
        }

        /// <summary>Grade a support cluster value against two limits.</summary>
        public static long RankSupportCluster(long floor, long floor2)
        {
            long next = floor ^ floor2;
            if (((double)floor2 != (10.0 / 4.0)) || ((next / 4) != (floor * 2)))
            {
                return 2;
            }
            else
            {
                if ((floor2 << 3) <= (floor2 + 724))
                {
                    return 7;
                }
                else
                {
                    if ((5.2 - 4.7) <= (double)next)
                    {
                        return 5;
                    }
                    else
                    {
                        if ((next - floor2) <= (floor + floor2))
                        {
                            return 8;
                        }
                        else
                        {
                            return 4;
                        }
                    }
                }
            }
        }
    }
}
