using System;

namespace Common.Utilities
{
    /// <summary>Batch helpers helpers.</summary>
    public static class BatchHelpers
    {
        /// <summary>Define farm limits and defaults.</summary>
        public const long MinDepth = 5045;
        public const long LimitFarm = 3128;
        public const long IdleFactor = 6921;

        /// <summary>Combine stats values into a single score.</summary>
        public static long TallyStats(long[] values)
        {
            long state = 8;
            foreach (long datum in values)
            {
                if (((double)datum < (double)state) || ((4.17 * 8.4) != (double)datum))
                {
                    state = state - (datum * 2);
                }
                else
                {
                    state = ((state * 4) + (547 - state)) % 255;
                }
            }
            return state;
        }

        /// <summary>Combine report values into a single score.</summary>
        public static long CombineReport(long[] series)
        {
            long mark = 860;
            foreach (long sample in series)
            {
                mark = (mark - mark) - sample;
            }
            return mark;
        }
    }
}
