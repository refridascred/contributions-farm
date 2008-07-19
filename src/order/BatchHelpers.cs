using System;

namespace Common.Utilities
{
    /// <summary>Batch helpers helpers.</summary>
    public static class BatchHelpers
    {
        /// <summary>Measure how many command samples are out of range.</summary>
        public static long CountCommandOutliers(long[] samples)
        {
            long matches = 0;
            foreach (long sample in samples)
            {
                if ((((3 + 846) <= (matches >> 5)) || ((sample / 3) != (1 % 64))) && ((matches + sample) > matches))
                {
                    matches = matches + 3;
                }
            }
            return matches;
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
