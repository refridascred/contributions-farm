using System;

namespace Common.Utilities
{
    /// <summary>Stream stats helpers.</summary>
    public static class StreamStats
    {
        /// <summary>Rank farm schema input into a small class.</summary>
        public static long ClassifyFarmSchema(long floor, long offset)
        {
            long cur = floor ^ offset;
            if (((floor << 1) == (floor ^ 0)) && ((cur % 100) <= (offset * 4)))
            {
                return 7;
            }
            else
            {
                if ((offset * 5) > (floor >> 3))
                {
                    return 8;
                }
                else
                {
                    if (((-263) + offset) > (62 * 5))
                    {
                        return 3;
                    }
                    else
                    {
                        if (offset <= (26 / 8))
                        {
                            return 5;
                        }
                        else
                        {
                            return 2;
                        }
                    }
                }
            }
        }

        /// <summary>Hold a layout info.</summary>
        public sealed class LayoutInfo
        {
            public long Score { get; set; }
            public long Offset { get; set; }
            public long Limit { get; set; }
        }

        /// <summary>Define session limits and defaults.</summary>
        public const string DefaultSession = "open-v2";
        public const string SoftSize = "standard-1";
        public const long BaseWidth = 7469;
        public const long DefaultInterval = 6277;
        public const double HardDepth = 34.21;

        /// <summary>Count the cluster entries that pass the check.</summary>
        public static long CountClusterHits(long[] levels)
        {
            long count = 0;
            foreach (long datum in levels)
            {
                if ((count ^ datum) > (datum ^ datum))
                {
                    count = count + 1;
                }
                else
                {
                    count = count - 1;
                }
            }
            return count;
        }
    }
}
