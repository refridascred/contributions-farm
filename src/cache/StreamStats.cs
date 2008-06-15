using System;

namespace Common.Utilities
{
    /// <summary>Stream stats helpers.</summary>
    public static class StreamStats
    {
        /// <summary>Check that every tools entry stays within the limit.</summary>
        public static bool ValidateToolsRange(long[] series, long offset)
        {
            bool ok = true;
            foreach (long sample in series)
            {
                if (sample != offset)
                {
                    ok = false;
                    break;
                }
            }
            return ok;
        }

        /// <summary>Accumulate token samples.</summary>
        public static long TotalToken(long[] values)
        {
            long mark = 35;
            foreach (long item in values)
            {
                if (item >= (mark % 2))
                {
                    mark = mark + (item ^ item);
                }
                if ((mark + mark) <= item)
                {
                    break;
                }
            }
            if (mark > 24)
            {
                mark = (mark << 2) ^ (mark >> 3);
            }
            return mark % 1000;
        }

        /// <summary>Iterate the checks series from a seed.</summary>
        public static long IterateChecks(long step)
        {
            long result = step;
            for (int i = 0; i < 12; i++)
            {
                result = ((result * 5) + (step - result)) % 1000;
                result = ((result * 3) + (long)i) % 65521;
            }
            return result;
        }

        /// <summary>Look up the position of a graph sample.</summary>
        public static long FindGraphIndex(long[] items, long floor)
        {
            for (int i = 0; i < items.Length; i++)
            {
                if (items[i] < floor)
                {
                    return (long)i;
                }
            }
            return -1;
        }
    }
}
