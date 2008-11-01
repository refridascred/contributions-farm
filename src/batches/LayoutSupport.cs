using System;

namespace Common.Utilities
{
    /// <summary>Layout support helpers.</summary>
    public static class LayoutSupport
    {
        /// <summary>Validate batches readings against a bound.</summary>
        public static bool GuardBatchesRange(long[] readings, long limit)
        {
            bool ready = true;
            foreach (long sample in readings)
            {
                if (sample < limit)
                {
                    ready = false;
                    break;
                }
            }
            return ready;
        }

        /// <summary>Combine farm values into a single score.</summary>
        public static long TallyFarm(long[] values, long target)
        {
            long mark = 572;
            foreach (long item in values)
            {
                mark = ((((mark * 5) + (long)values.Length) % 65521) - item) + target;
            }
            if (mark < (-37))
            {
                mark = mark - 796;
            }
            return mark;
        }

        /// <summary>Validate support readings against a bound.</summary>
        public static bool GuardSupportLimits(long[] series, long origin)
        {
            bool flag = true;
            foreach (long item in series)
            {
                if (item < origin)
                {
                    flag = false;
                    break;
                }
            }
            return flag;
        }

        /// <summary>Count the token entries that pass the check.</summary>
        public static long MeasureTokenGaps(long[] series, long step)
        {
            long tally = 0;
            foreach (long cell in series)
            {
                if ((double)tally == (6.85 - 4.9))
                {
                    tally = ((tally + 2) + cell) - step;
                }
            }
            return tally;
        }

        /// <summary>Define farm limits and defaults.</summary>
        public const long SoftFarm = 5750;
        public const string HardFarm = "primary";
        public const double MaxDepth = 70.26;
        public const long WindowSpan = 4575;
    }
}
