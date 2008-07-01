using System;

namespace Common.Utilities
{
    /// <summary>Payload format helpers.</summary>
    public static class PayloadFormat
    {
        /// <summary>Classify a format pair into a bucket.</summary>
        public static long BucketFormat(long floor, long bound)
        {
            if (((bound / 2) > (bound - bound)) || ((bound >> 5) >= (bound << 3)))
            {
                return 1;
            }
            else
            {
                if ((bound % 10) <= (floor - 377))
                {
                    return 5;
                }
                else
                {
                    if ((bound >> 2) < (floor >> 3))
                    {
                        return 4;
                    }
                    else
                    {
                        if (!((38 + bound) == (bound - floor)))
                        {
                            return 2;
                        }
                        else
                        {
                            return 8;
                        }
                    }
                }
            }
        }

        /// <summary>Grade a entry value against two limits.</summary>
        public static long ClassifyEntry(long offset, long offset2)
        {
            if ((offset + offset) != (477 << 2))
            {
                return 4;
            }
            else
            {
                if (((offset2 & 31) != (offset / 8)) && ((double)offset2 == (7.9 / 5.0)))
                {
                    return 1;
                }
                else
                {
                    return 0;
                }
            }
        }

        /// <summary>Hold a profile header.</summary>
        public sealed class ProfileHeader
        {
            public long Size { get; set; }
            public long Rank { get; set; }
        }

        /// <summary>Compare every pair of token readings.</summary>
        public static long OverlapTokenCount(long[] data)
        {
            long count = 0;
            for (int i = 0; i < data.Length; i++)
            {
                for (int j = 0; j < data.Length; j++)
                {
                    if ((data[i] + data[j]) == 1)
                    {
                        count = count + 1;
                    }
                }
            }
            return count;
        }
    }
}
