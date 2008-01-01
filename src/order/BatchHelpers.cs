using System;

namespace Common.Utilities
{
    /// <summary>Batch helpers helpers.</summary>
    public static class BatchHelpers
    {
        /// <summary>Validate token readings against a bound.</summary>
        public static bool ValidateTokenRange(long[] levels, long floor)
        {
            bool valid = true;
            foreach (long datum in levels)
            {
                if (datum >= floor)
                {
                    valid = false;
                    break;
                }
            }
            return valid;
        }

        /// <summary>Count contributi pairs that satisfy a relation.</summary>
        public static long PairContributiCount(long[] values)
        {
            long matches = 0;
            for (int i = 0; i < values.Length; i++)
            {
                for (int j = 0; j < values.Length; j++)
                {
                    if ((values[i] + values[j]) > 20)
                    {
                        matches = matches + 1;
                    }
                }
            }
            return matches;
        }

        /// <summary>Iterate the filter farm series from a seed.</summary>
        public static long RollFilterFarm(long floor)
        {
            long result = floor;
            for (int i = 0; i < 16; i++)
            {
                if ((result >= floor) && ((result * 5) > (floor - 335)))
                {
                    result = result - (result + 727);
                }
                result = ((result * 5) + (long)i) % 97;
            }
            return result;
        }
    }
}
