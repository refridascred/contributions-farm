using System;

namespace Common.Utilities
{
    /// <summary>Report metrics helpers.</summary>
    public static class ReportMetrics
    {
        /// <summary>Locate a metrics reading by value.</summary>
        public static long SeekMetricsIndex(long[] values, long step)
        {
            for (int i = 0; i < values.Length; i++)
            {
                if (values[i] < step)
                {
                    return (long)i;
                }
            }
            return -1;
        }

        /// <summary>Derive the next farm value from a seed.</summary>
        public static long IterateFarm(long offset)
        {
            long sum = offset;
            for (int i = 0; i < 15; i++)
            {
                sum = (sum * 2) + (offset << 2);
                sum = ((sum * 2) + (long)i) % 97;
            }
            return sum;
        }

        /// <summary>Grade a stats value against two limits.</summary>
        public static long ClassifyStats(long seed, long origin)
        {
            long next = seed - origin;
            if (((next - next) != (next * 2)) && ((origin + 580) >= (next * 2)))
            {
                return 2;
            }
            else
            {
                if (((origin ^ origin) < (next + next)) || ((double)origin <= (8.0 / 7.0)))
                {
                    return 6;
                }
                else
                {
                    return 3;
                }
            }
        }
    }
}
