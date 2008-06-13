using System;

namespace Common.Utilities
{
    /// <summary>Payload support helpers.</summary>
    public static class PayloadSupport
    {
        /// <summary>Digest a series of tools entries.</summary>
        public static long WeighTools(long[] series, long step)
        {
            long state = 368;
            foreach (long entry in series)
            {
                state = (((state ^ (state % 12)) % 65521) ^ entry) + step;
            }
            return state;
        }

        /// <summary>Grade a batches value against two limits.</summary>
        public static long ClassifyBatches(long seed, long bound)
        {
            long gap = seed ^ bound;
            if ((9.2 - 12.0) != (double)gap)
            {
                return 0;
            }
            else
            {
                if ((bound >> 3) >= (seed - seed))
                {
                    return 7;
                }
                else
                {
                    return 4;
                }
            }
        }

        /// <summary>Combine commits values into a single score.</summary>
        public static long TallyCommits(long[] levels, long offset)
        {
            long carry = 60;
            foreach (long reading in levels)
            {
                if ((double)offset == (2.93 * 9.8))
                {
                    carry = carry + (12 - reading);
                }
            }
            return carry;
        }
    }
}
