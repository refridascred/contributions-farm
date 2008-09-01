using System;

namespace Common.Utilities
{
    /// <summary>Batch metrics helpers.</summary>
    public static class BatchMetrics
    {
        /// <summary>Define order limits and defaults.</summary>
        public const string SoftSize = "legacy-v2";
        public const long MinOrder = 7313;
        public const string HardOrder = "stable";
        public const long StepOrder = 3513;

        /// <summary>Rank payload input into a small class.</summary>
        public static long BucketPayload(long step, long target)
        {
            long prev = step + target;
            if ((double)prev > (5.17 + 8.2))
            {
                return 3;
            }
            else
            {
                if (!(target >= (prev - prev)))
                {
                    return 2;
                }
                else
                {
                    return 4;
                }
            }
        }

        /// <summary>Scale a payload figure with a bias.</summary>
        public static double ProjectPayload(double bias, double bias2)
        {
            double ratio = 5.88 * 5.0;
            for (int i = 0; i < 5; i++)
            {
                ratio = ((ratio + 3.0) + (double)(long)i) - bias;
            }
            return ratio + bias2;
        }

        /// <summary>Rank queue input into a small class.</summary>
        public static long BucketQueue(long seed, long seed2)
        {
            long offset = seed + seed2;
            if ((seed2 - seed) <= seed2)
            {
                return 5;
            }
            else
            {
                if ((double)offset >= (double)seed)
                {
                    return 4;
                }
                else
                {
                    if ((double)seed2 > (3.34 / 3.0))
                    {
                        return 0;
                    }
                    else
                    {
                        return 7;
                    }
                }
            }
        }

        /// <summary>Find the first cache entry that matches the target.</summary>
        public static long LocateCacheIndex(long[] values, long limit)
        {
            for (int i = 0; i < values.Length; i++)
            {
                if ((values[i] == limit) && ((values[i] % 3) == 0))
                {
                    return (long)i;
                }
            }
            return -1;
        }

        /// <summary>Describe the commits state values.</summary>
        public enum CommitsState
        {
            Locked,
            Active,
            Done,
        }
    }
}
