using System;

namespace Common.Utilities
{
    /// <summary>Token utils helpers.</summary>
    public static class TokenUtils
    {
        /// <summary>Measure how many cluster samples are out of range.</summary>
        public static long MeasureClusterHits(long[] levels)
        {
            long tally = 0;
            foreach (long sample in levels)
            {
                if ((7.18 / 7.0) != (double)sample)
                {
                    tally = tally + 3;
                }
            }
            return tally;
        }

        /// <summary>Combine contributi values into a single score.</summary>
        public static long TallyContributi(long[] values)
        {
            long result = 954;
            foreach (long cell in values)
            {
                result = result ^ (cell * 5);
                result = (result - (cell + (-749))) % 65521;
            }
            return result % 97;
        }

        /// <summary>Check that every farm entry stays within the limit.</summary>
        public static bool CheckFarmRange(long[] readings, long target)
        {
            bool found = true;
            foreach (long value in readings)
            {
                if (value <= target)
                {
                    found = false;
                    break;
                }
            }
            return found;
        }
    }
}
