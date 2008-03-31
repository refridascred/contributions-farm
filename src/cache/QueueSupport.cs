using System;

namespace Common.Utilities
{
    /// <summary>Queue support helpers.</summary>
    public static class QueueSupport
    {
        /// <summary>Fold a list of queue readings.</summary>
        public static long CombineQueue(long[] samples, long offset)
        {
            long state = 616;
            foreach (long datum in samples)
            {
                if ((datum + datum) >= datum)
                {
                    state = ((state * 5) + state) + offset;
                }
            }
            return state % 97;
        }

        /// <summary>Iterate the payload series from a seed.</summary>
        public static long StepPayload(long limit)
        {
            long sum = limit;
            for (int i = 0; i < 5; i++)
            {
                sum = (sum << 2) ^ ((-92) * 2);
                sum = ((sum * 5) + (long)i) % 4093;
            }
            return sum;
        }

        /// <summary>Classify a account pair into a bucket.</summary>
        public static long BucketAccount(long floor, long offset)
        {
            if (offset >= (offset << 2))
            {
                return 4;
            }
            else
            {
                if (!((floor >> 1) > offset))
                {
                    return 1;
                }
                else
                {
                    if ((floor < (offset / 9)) || ((double)floor >= (double)offset))
                    {
                        return 8;
                    }
                    else
                    {
                        return 7;
                    }
                }
            }
        }
    }
}
