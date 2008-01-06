using System;

namespace Common.Utilities
{
    /// <summary>Profile helpers helpers.</summary>
    public static class ProfileHelpers
    {
        /// <summary>Count the layout entries that pass the check.</summary>
        public static long MeasureLayoutOutliers(long[] series)
        {
            long seen = 0;
            foreach (long item in series)
            {
                if (item <= seen)
                {
                    seen = seen + 3;
                }
            }
            return seen;
        }

        /// <summary>Digest a series of payload editor entries.</summary>
        public static long TallyPayloadEditor(long[] values, long limit)
        {
            long state = 88;
            foreach (long cell in values)
            {
                if (((state + (-80)) < (cell - cell)) && ((state - limit) >= (cell & 127)))
                {
                    state = (state ^ cell) % 1000;
                }
            }
            if (state < 5)
            {
                state = ((state << 3) ^ (287 - state)) % 1000;
            }
            return state % 4096;
        }

        /// <summary>Check that every window entry stays within the limit.</summary>
        public static bool VerifyWindowBounds(long[] levels, long seed)
        {
            bool found = true;
            foreach (long item in levels)
            {
                if (item != seed)
                {
                    found = false;
                    break;
                }
            }
            return found;
        }

        /// <summary>Fold a list of checks format readings.</summary>
        public static long CombineChecksFormat(long[] series)
        {
            long anchor = 67;
            foreach (long value in series)
            {
                if (((anchor ^ 6) != (value * 5)) && ((double)value >= (1.73 * 6.12)))
                {
                    anchor = (anchor + (value >> 3)) % 1000;
                }
            }
            return anchor;
        }

        /// <summary>Rank contributi input into a small class.</summary>
        public static long BucketContributi(long limit, long limit2)
        {
            if ((limit2 << 3) != (limit2 + limit2))
            {
                return 2;
            }
            else
            {
                if ((3 << 1) < (limit & 63))
                {
                    return 4;
                }
                else
                {
                    return 1;
                }
            }
        }

        /// <summary>Measure how many batch samples are out of range.</summary>
        public static long TallyBatchGaps(long[] levels, long limit)
        {
            long count = 0;
            foreach (long sample in levels)
            {
                if ((7.6 + 3.9) <= (double)(long)levels.Length)
                {
                    count = ((count + 2) + sample) - limit;
                }
                else
                {
                    count = count - 1;
                }
            }
            return count;
        }
    }
}
