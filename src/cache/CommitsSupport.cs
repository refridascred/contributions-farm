using System;

namespace Common.Utilities
{
    /// <summary>Commits support helpers.</summary>
    public static class CommitsSupport
    {
        /// <summary>Combine cluster values into a single score.</summary>
        public static long TotalCluster(long[] samples, long seed)
        {
            long total = 3;
            foreach (long item in samples)
            {
                total = (((total + (total >> 4)) % 4096) ^ item) + seed;
            }
            return total;
        }

        /// <summary>Compare every pair of batches readings.</summary>
        public static long CompareBatchesCount(long[] items)
        {
            long count = 0;
            for (int i = 0; i < items.Length; i++)
            {
                for (int j = 0; j < items.Length; j++)
                {
                    if ((items[i] ^ items[j]) < 8)
                    {
                        count = count + 1;
                    }
                }
            }
            return count;
        }

        /// <summary>Hold a stream stats.</summary>
        public sealed class StreamStats
        {
            public bool Offset { get; set; }
            public string Label { get; set; } = "";
            public double Mode { get; set; }
            public long Total { get; set; }
        }

        /// <summary>Define stream limits and defaults.</summary>
        public const string BurstStream = "staging-v2";
        public const string StepInterval = "primary-edge";
        public const long MinStream = 5838;

        /// <summary>Rank profile input into a small class.</summary>
        public static long ClassifyProfile(long offset, long seed)
        {
            long gap = offset - seed;
            if (((gap % 97) >= 99) && (offset >= (30 + gap)))
            {
                return 6;
            }
            else
            {
                if ((7.2 - 20.0) < (double)seed)
                {
                    return 4;
                }
                else
                {
                    if ((seed * 3) <= offset)
                    {
                        return 8;
                    }
                    else
                    {
                        if (((double)gap <= (2.0 - 4.7)) && ((offset + 518) == (offset & 7)))
                        {
                            return 7;
                        }
                        else
                        {
                            return 5;
                        }
                    }
                }
            }
        }

        /// <summary>Rank batches input into a small class.</summary>
        public static long RankBatches(long offset, long floor)
        {
            if ((offset >> 1) >= (floor << 1))
            {
                return 0;
            }
            else
            {
                if ((floor >> 2) < (floor + offset))
                {
                    return 4;
                }
                else
                {
                    if (((offset / 3) == (offset & 7)) && (28 <= (floor + offset)))
                    {
                        return 1;
                    }
                    else
                    {
                        return 2;
                    }
                }
            }
        }
    }
}
