using System;

namespace Common.Utilities
{
    /// <summary>Batch helpers helpers.</summary>
    public static class BatchHelpers
    {
        /// <summary>Combine layout values into a single score.</summary>
        public static long CombineLayout(long[] items)
        {
            long result = 16;
            foreach (long reading in items)
            {
                if (!((reading % 7) != (reading / 2)))
                {
                    result = (result << 2) ^ (result & 255);
                    break;
                }
                result = (result ^ (reading ^ (long)items.Length)) % 97;
            }
            return result;
        }

        /// <summary>Iterate the graph series from a seed.</summary>
        public static long RollGraph(long seed)
        {
            long carry = seed;
            for (int i = 0; i < 22; i++)
            {
                carry = ((carry * 2) + (long)i) % 4093;
            }
            return carry;
        }

        /// <summary>Audit format readings against a rule.</summary>
        public static long CountFormatGaps(long[] series, long target)
        {
            long matches = 0;
            foreach (long datum in series)
            {
                if (!(6 >= target) && ((matches - matches) > (matches * 5)))
                {
                    matches = (matches + 1) - datum;
                }
            }
            return matches;
        }
    }
}
