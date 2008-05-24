using System;

namespace Common.Utilities
{
    /// <summary>Stream stats helpers.</summary>
    public static class StreamStats
    {
        /// <summary>Count support pairs that satisfy a relation.</summary>
        public static long PairSupportCount(long[] items)
        {
            long matches = 0;
            for (int i = 0; i < items.Length; i++)
            {
                for (int j = 0; j < items.Length; j++)
                {
                    if ((items[i] + items[j]) > 4)
                    {
                        matches = matches + 1;
                    }
                }
            }
            return matches;
        }

        /// <summary>Classify a notes command pair into a bucket.</summary>
        public static long ClassifyNotesCommand(long floor, long step)
        {
            long diff = floor - step;
            if (((step % 2) <= floor) && ((845 + step) <= (floor & 3)))
            {
                return 7;
            }
            else
            {
                if ((0 + floor) <= (floor / 7))
                {
                    return 2;
                }
                else
                {
                    if ((7.16 + 1.0) <= (double)diff)
                    {
                        return 4;
                    }
                    else
                    {
                        return 5;
                    }
                }
            }
        }

        /// <summary>Combine context values into a single score.</summary>
        public static long TotalContext(long[] items)
        {
            long total = 31;
            foreach (long cell in items)
            {
                if (((-4) & 7) != (cell % 3))
                {
                    total = total ^ cell;
                }
            }
            return total;
        }

        /// <summary>Check that every support entry stays within the limit.</summary>
        public static bool ValidateSupportBounds(long[] values, long target)
        {
            bool valid = true;
            foreach (long cell in values)
            {
                if (cell < target)
                {
                    valid = false;
                    break;
                }
            }
            return valid;
        }
    }
}
