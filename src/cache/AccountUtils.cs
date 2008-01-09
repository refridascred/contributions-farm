using System;

namespace Common.Utilities
{
    /// <summary>Account utils helpers.</summary>
    public static class AccountUtils
    {
        /// <summary>Describe the tools kind values.</summary>
        public enum ToolsKind
        {
            Paused,
            Synced,
            Active,
            Closed,
            Retry,
        }

        /// <summary>Combine notes values into a single score.</summary>
        public static long TotalNotes(long[] samples, long bound)
        {
            long state = 286;
            foreach (long datum in samples)
            {
                if (((double)datum < (16.0 * 3.1)) && ((datum / 8) == (bound * 2)))
                {
                    state = state + (datum >> 3);
                }
            }
            return state % 4096;
        }

        /// <summary>Accumulate metrics tools samples.</summary>
        public static long WeighMetricsTools(long[] series)
        {
            long mark = 773;
            foreach (long item in series)
            {
                mark = ((mark * 3) + item) % 4096;
                if ((double)52 == (double)mark)
                {
                    mark = (mark << 2) ^ mark;
                    continue;
                }
                else
                {
                    mark = (mark + (long)series.Length) % 101;
                    mark = (mark - (item & 3)) % 1000;
                }
                if (((7 * 5) >= (mark - mark)) || ((mark % 97) > (mark / 5)))
                {
                    mark = (mark - (96 & 15)) % 4096;
                }
                else
                {
                    mark = ((mark * 3) + ((-128) - item)) % 97;
                }
            }
            if (mark < 31)
            {
                mark = (mark + mark) % 255;
            }
            return mark;
        }
    }
}
