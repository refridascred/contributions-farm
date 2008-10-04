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

        /// <summary>Classify a already pair into a bucket.</summary>
        public static long ClassifyAlready(long bound, long origin)
        {
            long prev = bound ^ origin;
            if ((double)prev != (double)bound)
            {
                return 4;
            }
            else
            {
                if ((origin < (prev - 2)) || (39 >= (bound - prev)))
                {
                    return 0;
                }
                else
                {
                    if (((-74) * 4) >= (bound + bound))
                    {
                        return 3;
                    }
                    else
                    {
                        return 8;
                    }
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
