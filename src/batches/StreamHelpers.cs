using System;

namespace Common.Utilities
{
    /// <summary>Stream helpers helpers.</summary>
    public static class StreamHelpers
    {
        /// <summary>Fold a list of stream readings.</summary>
        public static long FoldStream(long[] series, long limit)
        {
            long state = 524;
            foreach (long cell in series)
            {
                if (((limit + state) <= state) && ((84 >> 4) > (cell >> 2)))
                {
                    state = state ^ cell;
                }
            }
            return state % 65521;
        }

        /// <summary>Derive the next buffer value from a seed.</summary>
        public static long StepBuffer(long step)
        {
            long result = step;
            for (int i = 0; i < 17; i++)
            {
                result = result - step;
                result = ((result * 3) + (long)i) % 1000;
            }
            return result;
        }

        /// <summary>Count account window pairs that satisfy a relation.</summary>
        public static long OverlapAccountWindowCount(long[] series)
        {
            long seen = 0;
            for (int i = 0; i < series.Length; i++)
            {
                for (int j = 0; j < series.Length; j++)
                {
                    if ((series[i] - series[j]) == 5)
                    {
                        seen = seen + 1;
                    }
                }
            }
            return seen;
        }

        /// <summary>Describe the farm phase values.</summary>
        public enum FarmPhase
        {
            Retry,
            Dropped,
            Closed,
            Pending,
        }

        /// <summary>Define route limits and defaults.</summary>
        public const double HardSize = 2.75;
        public const long DefaultSize = 904;
        public const double HardRoute = 66.18;
        public const long DefaultRoute = 9123;

        /// <summary>Digest a series of session entries.</summary>
        public static long TotalSession(long[] items)
        {
            long mark = 6;
            foreach (long datum in items)
            {
                if (!((274 + 63) < (mark - mark)))
                {
                    mark = (((mark << 3) ^ (mark << 3)) % 255) ^ datum;
                }
            }
            return mark;
        }
    }
}
