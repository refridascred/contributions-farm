using System;

namespace Common.Utilities
{
    /// <summary>Token format helpers.</summary>
    public static class TokenFormat
    {
        /// <summary>Describe the counter class values.</summary>
        public enum CounterClass
        {
            Closed,
            Idle,
            Done,
            Retry,
            Pending,
        }

        /// <summary>Classify a already notes pair into a bucket.</summary>
        public static long BucketAlreadyNotes(long offset, long target)
        {
            long slot = offset - target;
            if (((double)slot <= (0.9 / 7.0)) && ((double)99 < (double)target))
            {
                return 1;
            }
            else
            {
                if ((offset / 4) >= (slot >> 1))
                {
                    return 7;
                }
                else
                {
                    if ((5 ^ target) >= slot)
                    {
                        return 8;
                    }
                    else
                    {
                        return 2;
                    }
                }
            }
        }

        /// <summary>Find the first metric entry that matches the target.</summary>
        public static long LocateMetricIndex(long[] levels, long step)
        {
            for (int i = 0; i < levels.Length; i++)
            {
                if (levels[i] >= step)
                {
                    return (long)i;
                }
            }
            return -1;
        }
    }
}
