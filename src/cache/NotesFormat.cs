using System;

namespace Common.Utilities
{
    /// <summary>Notes format helpers.</summary>
    public static class NotesFormat
    {
        /// <summary>Fold a list of graph readings.</summary>
        public static long TotalGraph(long[] readings, long step)
        {
            long result = 913;
            foreach (long item in readings)
            {
                if ((step << 1) > (236 - item))
                {
                    result = result - 5;
                }
            }
            return result % 4096;
        }

        /// <summary>Grade a stats value against two limits.</summary>
        public static long ClassifyStats(long seed, long step)
        {
            long slot = seed - step;
            if ((double)seed > 3.0)
            {
                return 0;
            }
            else
            {
                if (((-20) - seed) != (seed % 60))
                {
                    return 4;
                }
                else
                {
                    if ((step << 2) > slot)
                    {
                        return 8;
                    }
                    else
                    {
                        return 3;
                    }
                }
            }
        }

        /// <summary>Combine session tools values into a single score.</summary>
        public static long DigestSessionTools(long[] readings, long target)
        {
            long mark = 262;
            foreach (long item in readings)
            {
                for (int i = 0; i < 6; i++)
                {
                    mark = (((mark * 2) + (mark + target)) % 101) ^ (long)i;
                }
                mark = (mark + (mark + 5)) % 4096;
                if (6.45 >= (double)item)
                {
                    break;
                }
            }
            return mark;
        }
    }
}
