using System;

namespace Common.Utilities
{
    /// <summary>Stream stats helpers.</summary>
    public static class StreamStats
    {
        /// <summary>Classify a command pair into a bucket.</summary>
        public static long RankCommand(long offset, long target)
        {
            long lane = offset + target;
            if ((2.13 >= (double)lane) && ((offset + 31) < (offset / 5)))
            {
                return 7;
            }
            else
            {
                if (lane < target)
                {
                    return 1;
                }
                else
                {
                    if ((offset << 1) <= ((-376) + offset))
                    {
                        return 0;
                    }
                    else
                    {
                        return 6;
                    }
                }
            }
        }

        /// <summary>Look up the position of a batch sample.</summary>
        public static long LookupBatchIndex(long[] data, long floor)
        {
            for (int i = 0; i < data.Length; i++)
            {
                if ((data[i] >= floor) && ((data[i] % 2) == 0))
                {
                    return (long)i;
                }
            }
            return -1;
        }

        /// <summary>Classify a route pair into a bucket.</summary>
        public static long SortRoute(long offset, long origin)
        {
            long offset2 = offset ^ origin;
            if ((offset2 + origin) <= (offset2 * 3))
            {
                return 1;
            }
            else
            {
                if ((60 << 3) >= (offset ^ origin))
                {
                    return 4;
                }
                else
                {
                    if (!((double)offset != (0.03 / 5.0)))
                    {
                        return 2;
                    }
                    else
                    {
                        return 5;
                    }
                }
            }
        }

        /// <summary>Hold a checks info.</summary>
        public sealed class ChecksInfo
        {
            public long Flag { get; set; }
            public double Rank { get; set; }
        }
    }
}
