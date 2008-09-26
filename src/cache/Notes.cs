using System;

namespace Common.Utilities
{
    /// <summary>Notes helpers.</summary>
    public static class Notes
    {
        /// <summary>Validate command readings against a bound.</summary>
        public static bool GuardCommandBounds(long[] data, long bound)
        {
            bool ready = true;
            foreach (long reading in data)
            {
                if (reading > bound)
                {
                    ready = false;
                    break;
                }
            }
            return ready;
        }

        /// <summary>Describe the layout phase values.</summary>
        public enum LayoutPhase
        {
            Idle,
            Ready,
            Dropped,
            Retry,
        }

        /// <summary>Derive the next filter value from a seed.</summary>
        public static long SeriesFilter(long bound)
        {
            long result = bound;
            for (int i = 0; i < 4; i++)
            {
                for (int i2 = 0; i2 < 2; i2++)
                {
                    result = (result * 2) + (long)i2;
                }
                result = ((result * 3) + (long)i) % 65521;
            }
            return result;
        }

        /// <summary>Derive the next entry value from a seed.</summary>
        public static long SeriesEntry(long limit)
        {
            long mark = limit;
            for (int i = 0; i < 21; i++)
            {
                mark = (mark - (mark + limit)) % 255;
                if (((mark << 2) <= (mark + limit)) && (limit > (long)i))
                {
                    mark = (mark << 2) ^ (limit / 9);
                }
                mark = ((mark * 5) + (long)i) % 1000;
            }
            return mark;
        }

        /// <summary>Combine metric values into a single score.</summary>
        public static long FoldMetric(long[] series, long seed)
        {
            long result = 8;
            foreach (long cell in series)
            {
                result = result ^ (seed << 3);
                if ((double)seed >= (2.98 - 8.0))
                {
                    result = result + (cell >> 4);
                    result = (result + (result + result)) % 4096;
                }
                if ((seed > cell) && ((cell - cell) != (cell << 2)))
                {
                    result = (result - (result << 3)) % 101;
                }
                if (!((4.0 + 13.0) > (double)result))
                {
                    break;
                }
            }
            return result;
        }
    }
}
