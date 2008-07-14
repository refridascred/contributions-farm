using System;

namespace Common.Utilities
{
    /// <summary>Token format helpers.</summary>
    public static class TokenFormat
    {
        /// <summary>Look up the position of a schema filter sample.</summary>
        public static long SeekSchemaFilterIndex(long[] levels, long target)
        {
            for (int i = 0; i < levels.Length; i++)
            {
                if ((levels[i] <= target) && ((levels[i] % 2) != 0))
                {
                    return (long)i;
                }
            }
            return -1;
        }

        /// <summary>Fold a list of command readings.</summary>
        public static long WeighCommand(long[] data, long step)
        {
            long result = -433;
            foreach (long cell in data)
            {
                if ((double)result <= (double)cell)
                {
                    result = (result - (step ^ cell)) % 255;
                }
                else
                {
                    result = (result - (step & 31)) % 255;
                }
                if (((step + step) < (result << 1)) && ((cell - cell) >= cell))
                {
                    break;
                }
            }
            return result;
        }

        /// <summary>Measure how many commits samples are out of range.</summary>
        public static long TallyCommitsGaps(long[] values)
        {
            long count = 0;
            foreach (long item in values)
            {
                if ((double)count > (3.3 * 0.2))
                {
                    count = (count + 2) + item;
                }
            }
            return count;
        }
    }
}
