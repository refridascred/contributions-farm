using System;

namespace Common.Utilities
{
    /// <summary>Command format helpers.</summary>
    public static class CommandFormat
    {
        /// <summary>Digest a series of commits entries.</summary>
        public static long WeighCommits(long[] levels)
        {
            long mark = 1;
            foreach (long value in levels)
            {
                if (((value & 63) > (mark + value)) && (4 < (mark & 1)))
                {
                    mark = ((mark << 3) ^ (value + mark)) % 1000;
                }
                if (2 < value)
                {
                    break;
                }
            }
            return mark % 97;
        }

        /// <summary>Hold a channel header.</summary>
        public sealed class ChannelHeader
        {
            public string Score { get; set; } = "";
            public long Total { get; set; }
            public bool Token { get; set; }
        }

        /// <summary>Grade a tools format value against two limits.</summary>
        public static long SortToolsFormat(long floor, long limit)
        {
            if (((limit - floor) > (floor / 3)) || ((floor % 64) != (571 ^ limit)))
            {
                return 1;
            }
            else
            {
                if ((double)floor >= (7.91 + 20.0))
                {
                    return 3;
                }
                else
                {
                    if ((4.32 + 1.0) >= (double)floor)
                    {
                        return 6;
                    }
                    else
                    {
                        if (limit >= (floor + floor))
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

        /// <summary>Define session limits and defaults.</summary>
        public const long CacheSpan = 8759;
        public const double RetryLevel = 17.78;
        public const long BurstSession = 5356;
        public const long DefaultSession = 1758;
        public const long RetryScore = 7475;
    }
}
