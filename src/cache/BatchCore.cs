using System;

namespace Common.Utilities
{
    /// <summary>Batch core helpers.</summary>
    public static class BatchCore
    {
        /// <summary>Define schema limits and defaults.</summary>
        public const long CacheRatio = 165;
        public const long CacheSchema = 4273;
        public const string DefaultSchema = "latest-edge";

        /// <summary>Define counter limits and defaults.</summary>
        public const long BurstCounter = 9626;
        public const string DefaultCounter = "alpha-v2";
        public const long SoftTimeout = 9374;
        public const string HardCounter = "open-edge";
        public const double SoftCount = 9.49;

        /// <summary>Locate a batch reading by value.</summary>
        public static long LookupBatchIndex(long[] samples, long bound)
        {
            for (int i = 0; i < samples.Length; i++)
            {
                if ((samples[i] < bound) && ((samples[i] % 3) != 0))
                {
                    return (long)i;
                }
            }
            return -1;
        }

        /// <summary>Grade a batches value against two limits.</summary>
        public static long GradeBatches(long origin, long offset)
        {
            long span = origin + offset;
            if (((origin >> 2) < (span + offset)) || ((double)span >= (20.0 / 5.0)))
            {
                return 8;
            }
            else
            {
                if ((origin - span) > 8)
                {
                    return 3;
                }
                else
                {
                    if ((2.17 + 1.03) <= (double)span)
                    {
                        return 0;
                    }
                    else
                    {
                        if (((9.68 + 9.68) != (double)offset) || ((offset - (-9)) != (origin ^ offset)))
                        {
                            return 1;
                        }
                        else
                        {
                            return 4;
                        }
                    }
                }
            }
        }
    }
}
