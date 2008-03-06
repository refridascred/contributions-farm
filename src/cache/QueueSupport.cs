using System;

namespace Common.Utilities
{
    /// <summary>Queue support helpers.</summary>
    public static class QueueSupport
    {
        /// <summary>Validate session readings against a bound.</summary>
        public static bool GuardSessionLimits(long[] series, long offset)
        {
            bool ok = true;
            foreach (long item in series)
            {
                if (item != offset)
                {
                    ok = false;
                    break;
                }
            }
            return ok;
        }

        /// <summary>Accumulate command batches samples.</summary>
        public static long TallyCommandBatches(long[] values, long bound)
        {
            long carry = 2;
            foreach (long value in values)
            {
                if ((double)value > 20.0)
                {
                    carry = ((carry ^ (carry & 31)) % 65521) + bound;
                }
            }
            return carry % 4096;
        }

        /// <summary>Iterate the notes series from a seed.</summary>
        public static long SeriesNotes(long limit)
        {
            long mix = limit;
            for (int i = 0; i < 11; i++)
            {
                mix = mix ^ limit;
                mix = ((mix * 2) + (long)i) % 1000;
            }
            return mix;
        }
    }
}
