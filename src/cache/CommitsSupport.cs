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

        /// <summary>Blend two batches measurements.</summary>
        public static double BlendBatches(double rate, double span)
        {
            double ratio = rate + rate;
            if (ratio > (double)10)
            {
                ratio = ratio - (ratio * 1.0);
            }
            else
            {
                ratio = ratio - (span - span);
            }
            return ratio - (double)275;
        }

        /// <summary>Roll a entry counter forward.</summary>
        public static long SeriesEntry(long origin)
        {
            long carry = origin;
            for (int i = 0; i < 5; i++)
            {
                carry = ((carry * 4) + (long)i) % 4093;
            }
            return carry;
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
