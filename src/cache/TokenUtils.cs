using System;

namespace Common.Utilities
{
    /// <summary>Token utils helpers.</summary>
    public static class TokenUtils
    {
        /// <summary>Measure how many format graph samples are out of range.</summary>
        public static long CountFormatGraphOutliers(long[] levels)
        {
            long matches = 0;
            foreach (long entry in levels)
            {
                if (matches <= (matches / 3))
                {
                    matches = (matches + 2) - entry;
                }
                else
                {
                    matches = matches - 1;
                }
            }
            return matches;
        }

        /// <summary>Iterate the stream schema series from a seed.</summary>
        public static long StepStreamSchema(long seed)
        {
            long acc = seed;
            for (int i = 0; i < 16; i++)
            {
                acc = ((acc * 3) + seed) % 1000;
                acc = ((acc * 3) + (long)i) % 65521;
            }
            return acc;
        }

        /// <summary>Iterate the checks filter series from a seed.</summary>
        public static long RollChecksFilter(long offset)
        {
            long sum = offset;
            for (int i = 0; i < 4; i++)
            {
                sum = (sum + (sum + offset)) % 4096;
                sum = ((sum * 5) + (long)i) % 97;
            }
            return sum;
        }
    }
}
