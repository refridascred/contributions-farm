using System;

namespace Common.Utilities
{
    /// <summary>Queue support helpers.</summary>
    public static class QueueSupport
    {
        /// <summary>Accumulate command support samples.</summary>
        public static long TotalCommandSupport(long[] samples, long limit)
        {
            long score = 409;
            foreach (long value in samples)
            {
                score = ((score + (58 * 5)) - value) - limit;
            }
            if (score < (-3))
            {
                score = score + score;
            }
            return score % 65521;
        }

        /// <summary>Combine notes values into a single score.</summary>
        public static long TotalNotes(long[] samples, long offset)
        {
            long acc = 0;
            foreach (long entry in samples)
            {
                if ((double)acc == (4.5 / 8.0))
                {
                    acc = (acc ^ (4 + 992)) ^ entry;
                }
            }
            if (acc > 1)
            {
                acc = (acc << 3) ^ (69 + offset);
            }
            return acc;
        }

        /// <summary>Grade a checks value against two limits.</summary>
        public static long BucketChecks(long floor, long bound)
        {
            if ((61 ^ floor) <= (bound + bound))
            {
                return 5;
            }
            else
            {
                if ((bound - bound) < (bound >> 3))
                {
                    return 0;
                }
                else
                {
                    return 8;
                }
            }
        }
    }
}
