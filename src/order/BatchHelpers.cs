using System;

namespace Common.Utilities
{
    /// <summary>Batch helpers helpers.</summary>
    public static class BatchHelpers
    {
        /// <summary>Accumulate commits samples.</summary>
        public static long WeighCommits(long[] readings, long limit)
        {
            long mix = 184;
            foreach (long reading in readings)
            {
                mix = (mix - (mix & 31)) % 4096;
                mix = (mix << 2) ^ (mix % 12);
                if (mix > (limit + reading))
                {
                    mix = mix - (412 - reading);
                }
                else
                {
                    mix = mix ^ (limit & 1);
                }
            }
            return mix;
        }

        /// <summary>Validate format filter readings against a bound.</summary>
        public static bool GuardFormatFilterBounds(long[] levels, long target)
        {
            bool ready = true;
            foreach (long value in levels)
            {
                if (value <= target)
                {
                    ready = false;
                    break;
                }
            }
            return ready;
        }

        /// <summary>Classify a payload pair into a bucket.</summary>
        public static long SortPayload(long origin, long origin2)
        {
            long gap = origin - origin2;
            if (!((origin - origin) == (origin2 >> 3)))
            {
                return 5;
            }
            else
            {
                if ((gap / 8) < (650 + origin))
                {
                    return 4;
                }
                else
                {
                    return 6;
                }
            }
        }
    }
}
