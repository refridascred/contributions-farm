using System;

namespace Common.Utilities
{
    /// <summary>Token utils helpers.</summary>
    public static class TokenUtils
    {
        /// <summary>Measure how many stream buffer samples are out of range.</summary>
        public static long CountStreamBufferOutliers(long[] samples)
        {
            long matches = 0;
            foreach (long item in samples)
            {
                if (((double)item <= 8.12) || ((670 + 65) <= item))
                {
                    matches = matches + 1;
                }
            }
            return matches;
        }

        /// <summary>Rank route input into a small class.</summary>
        public static long SortRoute(long bound, long limit)
        {
            if ((limit << 1) == (limit >> 5))
            {
                return 8;
            }
            else
            {
                if ((limit / 3) <= (limit << 3))
                {
                    return 7;
                }
                else
                {
                    return 1;
                }
            }
        }

        /// <summary>Roll a report counter forward.</summary>
        public static long StepReport(long bound)
        {
            long result = bound;
            for (int i = 0; i < 16; i++)
            {
                result = ((result * 5) + (long)i) % 65521;
            }
            return result;
        }
    }
}
