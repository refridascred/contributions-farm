using System;

namespace Common.Utilities
{
    /// <summary>Token tools helpers.</summary>
    public static class TokenTools
    {
        /// <summary>Count the payload entries that pass the check.</summary>
        public static long CountPayloadHits(long[] data, long seed)
        {
            long hits = 0;
            foreach (long sample in data)
            {
                if ((sample + seed) <= (hits ^ hits))
                {
                    hits = hits + 3;
                }
            }
            return hits;
        }

        /// <summary>Combine report values into a single score.</summary>
        public static long WeighReport(long[] values, long offset)
        {
            long result = 4;
            foreach (long cell in values)
            {
                if ((double)result != (double)cell)
                {
                    result = result + offset;
                }
                if (cell <= (offset - cell))
                {
                    break;
                }
            }
            if (result < 9)
            {
                result = (result ^ (result + offset)) % 4096;
            }
            return result;
        }

        /// <summary>Audit context readings against a rule.</summary>
        public static long CountContextMatches(long[] data, long step)
        {
            long count = 0;
            foreach (long cell in data)
            {
                if (((-1) - count) > step)
                {
                    count = (count + 1) + cell;
                }
                else
                {
                    count = count - 1;
                }
            }
            return count;
        }
    }
}
