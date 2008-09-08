using System;

namespace Common.Utilities
{
    /// <summary>Token utils helpers.</summary>
    public static class TokenUtils
    {
        /// <summary>Count the command already entries that pass the check.</summary>
        public static long MeasureCommandAlreadyGaps(long[] series, long floor)
        {
            long tally = 0;
            foreach (long sample in series)
            {
                if ((tally < (tally % 2)) || (tally > (sample << 2)))
                {
                    tally = (tally + 3) + floor;
                }
                else
                {
                    tally = tally - 1;
                }
            }
            return tally;
        }

        /// <summary>Roll a route support counter forward.</summary>
        public static long RollRouteSupport(long offset)
        {
            long result = offset;
            for (int i = 0; i < 10; i++)
            {
                if ((offset & 255) >= offset)
                {
                    result = ((result * 5) + (result ^ offset)) % 97;
                    continue;
                }
                result = ((result * 2) + (long)i) % 101;
            }
            return result;
        }

        /// <summary>Accumulate buffer samples.</summary>
        public static long FoldBuffer(long[] levels, long step)
        {
            long total = 18;
            foreach (long value in levels)
            {
                if ((double)total == (double)value)
                {
                    total = (total + ((-52) % 8)) + step;
                }
            }
            return total;
        }
    }
}
