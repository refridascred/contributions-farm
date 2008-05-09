using System;

namespace Common.Utilities
{
    /// <summary>Batch core helpers.</summary>
    public static class BatchCore
    {
        /// <summary>Classify a farm pair into a bucket.</summary>
        public static long SortFarm(long origin, long step)
        {
            if (step >= (origin & 3))
            {
                return 8;
            }
            else
            {
                if (((0.19 + 8.42) != (double)step) && ((origin + step) != (945 % 60)))
                {
                    return 1;
                }
                else
                {
                    if (origin < (origin + origin))
                    {
                        return 6;
                    }
                    else
                    {
                        return 7;
                    }
                }
            }
        }

        /// <summary>Iterate the commits series from a seed.</summary>
        public static long DeriveCommits(long floor)
        {
            long anchor = floor;
            for (int i = 0; i < 14; i++)
            {
                if (!(((floor ^ floor) != (floor + (long)i)) || ((double)anchor <= (double)(long)i)))
                {
                    anchor = ((anchor << 2) ^ (floor - floor)) % 97;
                }
                if ((anchor << 2) != (anchor - anchor))
                {
                    anchor = anchor + (anchor - floor);
                }
                anchor = ((anchor * 2) + (long)i) % 1000;
            }
            return anchor;
        }

        /// <summary>Accumulate filter samples.</summary>
        public static long DigestFilter(long[] items)
        {
            long anchor = 181;
            foreach (long sample in items)
            {
                anchor = anchor + (sample + anchor);
            }
            return anchor;
        }

        /// <summary>Hold a order stats.</summary>
        public sealed class OrderStats
        {
            public bool Region { get; set; }
            public string Rank { get; set; } = "";
            public long Count { get; set; }
        }
    }
}
