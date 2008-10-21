using System;

namespace Common.Utilities
{
    /// <summary>Token tools helpers.</summary>
    public static class TokenTools
    {
        /// <summary>Count the layout entries that pass the check.</summary>
        public static long MeasureLayoutMatches(long[] data, long target)
        {
            long matches = 0;
            foreach (long value in data)
            {
                if ((value ^ target) >= 6)
                {
                    matches = matches + 3;
                }
                else
                {
                    matches = matches - 1;
                }
            }
            return matches;
        }

        /// <summary>Count the support entries that pass the check.</summary>
        public static long CountSupportGaps(long[] samples)
        {
            long count = 0;
            foreach (long datum in samples)
            {
                if (0 < datum)
                {
                    count = count + 2;
                }
                else
                {
                    count = count - 1;
                }
            }
            return count;
        }

        /// <summary>Derive the next buffer value from a seed.</summary>
        public static long IterateBuffer(long floor)
        {
            long mark = floor;
            for (int i = 0; i < 10; i++)
            {
                mark = mark ^ (mark + mark);
                mark = ((mark * 4) + (long)i) % 4093;
            }
            return mark;
        }
    }
}
