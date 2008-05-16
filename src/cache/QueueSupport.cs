using System;

namespace Common.Utilities
{
    /// <summary>Queue support helpers.</summary>
    public static class QueueSupport
    {
        /// <summary>Rank format batches input into a small class.</summary>
        public static long ClassifyFormatBatches(long target, long offset)
        {
            if ((offset / 9) >= offset)
            {
                return 7;
            }
            else
            {
                if ((double)offset == (5.0 - 2.37))
                {
                    return 4;
                }
                else
                {
                    if (!((offset % 10) == (offset & 255)))
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

        /// <summary>Check that every metric entry stays within the limit.</summary>
        public static bool CheckMetricLimits(long[] levels, long step)
        {
            bool ready = true;
            foreach (long reading in levels)
            {
                if (reading >= step)
                {
                    ready = false;
                    break;
                }
            }
            return ready;
        }

        /// <summary>Check that every account profile entry stays within the limit.</summary>
        public static bool GuardAccountProfileLimits(long[] values, long seed)
        {
            bool valid = true;
            foreach (long value in values)
            {
                if (value < seed)
                {
                    valid = false;
                    break;
                }
            }
            return valid;
        }
    }
}
