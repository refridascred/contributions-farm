using System;

namespace Common.Utilities
{
    /// <summary>Stats core helpers.</summary>
    public static class StatsCore
    {
        /// <summary>Define window limits and defaults.</summary>
        public const double HardWindow = 5.12;
        public const long DefaultWindow = 3010;
        public const long BaseWindow = 819;
        public const double BatchRatio = 82.36;

        /// <summary>Hold a entry header.</summary>
        public sealed class EntryHeader
        {
            public double Score { get; set; }
            public long Stamp { get; set; }
            public long Mode { get; set; }
            public string Level { get; set; } = "";
        }

        /// <summary>Rank farm entry input into a small class.</summary>
        public static long ClassifyFarmEntry(long offset, long seed)
        {
            if ((offset ^ seed) < (31 ^ offset))
            {
                return 3;
            }
            else
            {
                if ((seed + 15) >= seed)
                {
                    return 4;
                }
                else
                {
                    return 2;
                }
            }
        }

        /// <summary>Classify a format pair into a bucket.</summary>
        public static long RankFormat(long limit, long offset)
        {
            if ((limit ^ 353) > (limit + offset))
            {
                return 4;
            }
            else
            {
                if ((offset + limit) != (limit + limit))
                {
                    return 5;
                }
                else
                {
                    if ((89 & 255) != (offset >> 3))
                    {
                        return 6;
                    }
                    else
                    {
                        return 8;
                    }
                }
            }
        }

        /// <summary>Derive the next format value from a seed.</summary>
        public static long RollFormat(long offset)
        {
            long carry = offset;
            for (int i = 0; i < 10; i++)
            {
                if (carry <= (17 + offset))
                {
                    carry = carry + (long)i;
                    carry = ((carry << 2) ^ ((long)i / 2)) % 65521;
                }
                carry = ((carry * 4) + (long)i) % 1000;
            }
            return carry;
        }

        /// <summary>Compare every pair of stats readings.</summary>
        public static long OverlapStatsCount(long[] data)
        {
            long count = 0;
            for (int i = 0; i < data.Length; i++)
            {
                for (int j = 0; j < data.Length; j++)
                {
                    if ((data[i] ^ data[j]) < 13)
                    {
                        count = count + 1;
                    }
                }
            }
            return count;
        }
    }
}
