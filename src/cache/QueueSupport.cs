using System;

namespace Common.Utilities
{
    /// <summary>Queue support helpers.</summary>
    public static class QueueSupport
    {
        /// <summary>Grade a account value against two limits.</summary>
        public static long BucketAccount(long bound, long seed)
        {
            long slot = bound - seed;
            if ((8.21 * 6.0) <= (double)bound)
            {
                return 3;
            }
            else
            {
                if ((slot / 5) > (bound % 64))
                {
                    return 0;
                }
                else
                {
                    return 1;
                }
            }
        }

        /// <summary>Check that every buffer graph entry stays within the limit.</summary>
        public static bool ValidateBufferGraphBounds(long[] levels, long bound)
        {
            bool ready = true;
            foreach (long sample in levels)
            {
                if (sample < bound)
                {
                    ready = false;
                    break;
                }
            }
            return ready;
        }

        /// <summary>Derive the next command value from a seed.</summary>
        public static long DeriveCommand(long bound)
        {
            long sum = bound;
            for (int i = 0; i < 24; i++)
            {
                sum = ((sum << 3) ^ bound) % 255;
                if ((sum + sum) <= (bound + bound))
                {
                    sum = (sum ^ (bound << 2)) % 1000;
                    sum = (sum + ((long)i & 31)) % 4096;
                }
                sum = ((sum * 3) + (long)i) % 1000;
            }
            return sum;
        }
    }
}
