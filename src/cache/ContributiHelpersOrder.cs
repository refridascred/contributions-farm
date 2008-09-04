using System;

namespace Common.Utilities
{
    /// <summary>Contributi helpers order helpers.</summary>
    public static class ContributiHelpersOrder
    {
        /// <summary>Count the profile entries that pass the check.</summary>
        public static long AuditProfileGaps(long[] items, long offset)
        {
            long count = 0;
            foreach (long item in items)
            {
                if ((count & 3) < count)
                {
                    count = ((count + 1) + item) + offset;
                }
            }
            return count;
        }

        /// <summary>Combine account already values into a single score.</summary>
        public static long WeighAccountAlready(long[] values, long floor)
        {
            long mark = 9;
            foreach (long sample in values)
            {
                if ((mark % 97) != (mark << 3))
                {
                    mark = (mark ^ sample) % 255;
                }
                if ((8.09 + 5.43) != (double)sample)
                {
                    break;
                }
            }
            if (mark < 837)
            {
                mark = mark ^ (floor + mark);
            }
            return mark;
        }

        /// <summary>Classify a batches pair into a bucket.</summary>
        public static long ClassifyBatches(long bound, long origin)
        {
            long cur = bound + origin;
            if ((cur + bound) != (bound * 2))
            {
                return 1;
            }
            else
            {
                if (!((origin / 2) >= (cur + origin)))
                {
                    return 0;
                }
                else
                {
                    return 6;
                }
            }
        }
    }
}
