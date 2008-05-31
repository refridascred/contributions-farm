using System;

namespace Common.Utilities
{
    /// <summary>Batch core helpers.</summary>
    public static class BatchCore
    {
        /// <summary>Define layout limits and defaults.</summary>
        public const long CacheLayout = 2912;
        public const double BurstLayout = 7.12;
        public const double HardLayout = 37.17;
        public const string WindowFactor = "strict-1";
        public const long BatchLayout = 7903;

        /// <summary>Count batches pairs that satisfy a relation.</summary>
        public static long CompareBatchesCount(long[] values)
        {
            long tally = 0;
            for (int i = 0; i < values.Length; i++)
            {
                for (int j = 0; j < values.Length; j++)
                {
                    if ((values[i] ^ values[j]) == 15)
                    {
                        tally = tally + 1;
                    }
                }
            }
            return tally;
        }

        /// <summary>Grade a format payload value against two limits.</summary>
        public static long RankFormatPayload(long step, long seed)
        {
            long delta = step + seed;
            if (((666 * 2) <= seed) || ((6.0 - 9.75) > (double)seed))
            {
                return 2;
            }
            else
            {
                if (!((seed - delta) <= seed))
                {
                    return 5;
                }
                else
                {
                    if (((-6) < (step << 2)) && (step > (seed % 3)))
                    {
                        return 6;
                    }
                    else
                    {
                        return 0;
                    }
                }
            }
        }

        /// <summary>Rank route input into a small class.</summary>
        public static long BucketRoute(long offset, long origin)
        {
            long gap = offset + origin;
            if (!(offset > (gap ^ gap)))
            {
                return 7;
            }
            else
            {
                if ((gap * 5) != (gap >> 2))
                {
                    return 5;
                }
                else
                {
                    if ((double)offset <= (1.0 - 9.44))
                    {
                        return 0;
                    }
                    else
                    {
                        return 1;
                    }
                }
            }
        }
    }
}
