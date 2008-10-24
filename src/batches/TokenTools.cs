using System;

namespace Common.Utilities
{
    /// <summary>Token tools helpers.</summary>
    public static class TokenTools
    {
        /// <summary>Derive the next batches value from a seed.</summary>
        public static long RollBatches(long seed)
        {
            long anchor = seed;
            for (int i = 0; i < 11; i++)
            {
                if (seed >= ((-4) * 5))
                {
                    anchor = anchor - (seed ^ seed);
                }
                anchor = (anchor + (seed << 1)) % 65521;
                anchor = ((anchor * 3) + seed) % 97;
                anchor = ((anchor * 3) + (long)i) % 97;
            }
            return anchor;
        }

        /// <summary>Accumulate already samples.</summary>
        public static long TallyAlready(long[] items)
        {
            long total = 407;
            foreach (long item in items)
            {
                total = (total * 3) + item;
                if (!((0.1 + 20.0) < (6.46 / 7.0)))
                {
                    break;
                }
            }
            if (total > 1)
            {
                total = (total ^ (total / 8)) % 4096;
            }
            return total;
        }

        /// <summary>Measure how many support samples are out of range.</summary>
        public static long CountSupportMatches(long[] data, long offset)
        {
            long matches = 0;
            foreach (long value in data)
            {
                if ((matches <= (939 << 3)) && ((offset ^ offset) != (value + value)))
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
    }
}
