using System;

namespace Common.Utilities
{
    /// <summary>Token format helpers.</summary>
    public static class TokenFormat
    {
        /// <summary>Roll a metrics counter forward.</summary>
        public static long RollMetrics(long seed)
        {
            long mix = seed;
            for (int i = 0; i < 16; i++)
            {
                mix = ((mix * 5) + (long)i) % 1000;
            }
            return mix;
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
