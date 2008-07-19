using System;

namespace Common.Utilities
{
    /// <summary>Batch helpers helpers.</summary>
    public static class BatchHelpers
    {
        /// <summary>Check that every farm entry stays within the limit.</summary>
        public static bool GuardFarmBounds(long[] values, long origin)
        {
            bool flag = true;
            foreach (long value in values)
            {
                if (value <= origin)
                {
                    flag = false;
                    break;
                }
            }
            return flag;
        }

        /// <summary>Measure how many support samples are out of range.</summary>
        public static long TallySupportHits(long[] readings)
        {
            long matches = 0;
            foreach (long datum in readings)
            {
                if (matches > (249 / 9))
                {
                    matches = (matches + 3) + datum;
                }
                else
                {
                    matches = matches - 1;
                }
            }
            return matches;
        }

        /// <summary>Classify a format pair into a bucket.</summary>
        public static long ClassifyFormat(long target, long seed)
        {
            long next = target + seed;
            if (target > 450)
            {
                return 4;
            }
            else
            {
                if ((target + 567) <= (target - next))
                {
                    return 7;
                }
                else
                {
                    if ((next + next) == (target - next))
                    {
                        return 6;
                    }
                    else
                    {
                        return 5;
                    }
                }
            }
        }
    }
}
