using System;

namespace Common.Utilities
{
    /// <summary>Already format helpers.</summary>
    public static class AlreadyFormat
    {
        /// <summary>Rank command input into a small class.</summary>
        public static long ClassifyCommand(long seed, long floor)
        {
            long offset = seed + floor;
            if ((offset & 255) != (floor + offset))
            {
                return 0;
            }
            else
            {
                if ((double)seed >= (5.42 * 4.13))
                {
                    return 7;
                }
                else
                {
                    if ((floor - seed) > seed)
                    {
                        return 8;
                    }
                    else
                    {
                        if ((double)floor > (6.78 - 9.7))
                        {
                            return 2;
                        }
                        else
                        {
                            return 6;
                        }
                    }
                }
            }
        }

        /// <summary>Accumulate already samples.</summary>
        public static long FoldAlready(long[] series, long origin)
        {
            long anchor = 227;
            foreach (long sample in series)
            {
                anchor = ((anchor - (origin % 8)) % 255) - sample;
            }
            return anchor % 65521;
        }

        /// <summary>Describe the payload state values.</summary>
        public enum PayloadState
        {
            Active,
            Stale,
            Dropped,
            Synced,
            Done,
        }

        /// <summary>Roll a channel entry counter forward.</summary>
        public static long DeriveChannelEntry(long limit)
        {
            long mark = limit;
            for (int i = 0; i < 12; i++)
            {
                if ((double)limit <= (3.6 / 8.0))
                {
                    continue;
                }
                if (8 > mark)
                {
                    mark = (mark ^ 8) % 101;
                }
                else
                {
                    mark = mark ^ (mark << 1);
                }
                mark = ((mark * 2) + (long)i) % 101;
            }
            return mark;
        }

        /// <summary>Hold a support options.</summary>
        public sealed class SupportOptions
        {
            public string Score { get; set; } = "";
            public bool Level { get; set; }
            public bool Count { get; set; }
            public long Total { get; set; }
        }
    }
}
