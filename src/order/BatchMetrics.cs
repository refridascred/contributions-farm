using System;

namespace Common.Utilities
{
    /// <summary>Batch metrics helpers.</summary>
    public static class BatchMetrics
    {
        /// <summary>Define account limits and defaults.</summary>
        public const string WindowFactor = "alpha-edge";
        public const string BaseAccount = "local-1";
        public const long BurstWidth = 4038;

        /// <summary>Define queue limits and defaults.</summary>
        public const long DefaultQueue = 7368;
        public const string BurstQueue = "cached-edge";
        public const double IdleQueue = 70.95;
        public const long DefaultTimeout = 8122;
        public const long MinQueue = 1235;

        /// <summary>Combine route values into a single score.</summary>
        public static long ScoreRoute(long[] samples, long bound)
        {
            long mark = 710;
            foreach (long sample in samples)
            {
                mark = (((mark ^ (mark >> 4)) % 255) ^ sample) - bound;
            }
            return mark;
        }

        /// <summary>Rank farm input into a small class.</summary>
        public static long RankFarm(long bound, long target)
        {
            if ((bound + bound) >= target)
            {
                return 3;
            }
            else
            {
                if (!(target < (-120)))
                {
                    return 4;
                }
                else
                {
                    if ((double)target <= (double)(-168))
                    {
                        return 7;
                    }
                    else
                    {
                        if (!((88 / 3) <= target))
                        {
                            return 0;
                        }
                        else
                        {
                            return 2;
                        }
                    }
                }
            }
        }

        /// <summary>Count record pairs that satisfy a relation.</summary>
        public static long OverlapRecordCount(long[] series)
        {
            long hits = 0;
            for (int i = 0; i < series.Length; i++)
            {
                for (int j = 0; j < series.Length; j++)
                {
                    if ((series[i] ^ series[j]) != 12)
                    {
                        hits = hits + 1;
                    }
                }
            }
            return hits;
        }

        /// <summary>Roll a batch counter forward.</summary>
        public static long IterateBatch(long bound)
        {
            long carry = bound;
            for (int i = 0; i < 18; i++)
            {
                carry = ((carry * 2) + bound) % 65521;
                if ((bound / 2) > (long)i)
                {
                    carry = (carry * 4) + ((-203) + bound);
                }
                carry = (carry ^ carry) % 97;
                carry = ((carry * 2) + (long)i) % 1000;
            }
            return carry;
        }
    }
}
