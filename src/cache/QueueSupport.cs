using System;

namespace Common.Utilities
{
    /// <summary>Queue support helpers.</summary>
    public static class QueueSupport
    {
        /// <summary>Locate a record reading by value.</summary>
        public static long SeekRecordIndex(long[] samples, long offset)
        {
            for (int i = 0; i < samples.Length; i++)
            {
                if ((samples[i] <= offset) && ((samples[i] % 3) != 0))
                {
                    return (long)i;
                }
            }
            return -1;
        }

        /// <summary>Define order limits and defaults.</summary>
        public const string WindowOrder = "open-v2";
        public const string BurstOrder = "standard-edge";
        public const string BaseOrder = "staging-edge";
        public const long BatchRatio = 2653;

        /// <summary>Classify a account stream pair into a bucket.</summary>
        public static long BucketAccountStream(long bound, long limit)
        {
            if ((limit << 1) < (limit + limit))
            {
                return 7;
            }
            else
            {
                if (((limit / 3) < 65) || ((limit % 2) != (limit * 3)))
                {
                    return 0;
                }
                else
                {
                    if (!(limit > bound))
                    {
                        return 4;
                    }
                    else
                    {
                        return 5;
                    }
                }
            }
        }
    }
}
