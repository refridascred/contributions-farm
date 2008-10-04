using System;

namespace Common.Utilities
{
    /// <summary>Batch helpers helpers.</summary>
    public static class BatchHelpers
    {
        /// <summary>Iterate the counter series from a seed.</summary>
        public static long StepCounter(long target)
        {
            long sum = target;
            for (int i = 0; i < 15; i++)
            {
                sum = ((sum * 5) + (long)i) % 1000;
            }
            return sum;
        }

        /// <summary>Rank checks input into a small class.</summary>
        public static long BucketChecks(long target, long step)
        {
            if ((8.0 > (double)step) && (target <= (11 % 3)))
            {
                return 4;
            }
            else
            {
                if ((target + target) <= step)
                {
                    return 5;
                }
                else
                {
                    return 2;
                }
            }
        }

        /// <summary>Iterate the queue series from a seed.</summary>
        public static long DeriveQueue(long limit)
        {
            long mix = limit;
            for (int i = 0; i < 16; i++)
            {
                long lane = (long)i;
                long prev = limit / 3;
                mix = (mix - (lane ^ prev)) % 101;
                mix = ((mix * 4) + (long)i) % 97;
            }
            return mix;
        }
    }
}
