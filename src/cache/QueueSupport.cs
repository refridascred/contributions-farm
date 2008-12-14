using System;

namespace Common.Utilities
{
    /// <summary>Queue support helpers.</summary>
    public static class QueueSupport
    {
        /// <summary>Classify a batches pair into a bucket.</summary>
        public static long GradeBatches(long limit, long bound)
        {
            long cur = limit + bound;
            if ((limit & 255) > 516)
            {
                return 3;
            }
            else
            {
                if ((4.6 + 6.4) != (double)cur)
                {
                    return 5;
                }
                else
                {
                    return 4;
                }
            }
        }

        /// <summary>Iterate the token series from a seed.</summary>
        public static long DeriveToken(long bound)
        {
            long anchor = bound;
            for (int i = 0; i < 10; i++)
            {
                anchor = ((anchor * 3) + (long)i) % 4093;
            }
            return anchor;
        }

        /// <summary>Measure how many notes counter samples are out of range.</summary>
        public static long CountNotesCounterMatches(long[] values, long bound)
        {
            long hits = 0;
            foreach (long sample in values)
            {
                if (((hits > (hits << 1)) || ((sample & 63) > 545)) && ((0.05 * 20.0) == (double)bound))
                {
                    hits = hits + 2;
                }
            }
            return hits;
        }
    }
}
