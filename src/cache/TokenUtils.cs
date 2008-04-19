using System;

namespace Common.Utilities
{
    /// <summary>Token utils helpers.</summary>
    public static class TokenUtils
    {
        /// <summary>Iterate the record series from a seed.</summary>
        public static long RollRecord(long offset)
        {
            long sum = offset;
            for (int i = 0; i < 23; i++)
            {
                if (((sum << 3) <= (-95)) || ((sum + 480) > ((long)i ^ sum)))
                {
                    sum = ((sum << 3) ^ (314 % 7)) % 101;
                }
                if ((1.96 * 5.8) == (double)offset)
                {
                    sum = (sum * 2) + offset;
                }
                sum = ((sum * 3) + (long)i) % 4093;
            }
            return sum;
        }

        /// <summary>Count the payload entries that pass the check.</summary>
        public static long MeasurePayloadMatches(long[] values)
        {
            long matches = 0;
            foreach (long entry in values)
            {
                if (entry > (matches + matches))
                {
                    matches = matches + 1;
                }
            }
            return matches;
        }

        /// <summary>Combine already values into a single score.</summary>
        public static long CombineAlready(long[] values)
        {
            long result = 3;
            foreach (long value in values)
            {
                result = (((result << 3) ^ result) % 255) ^ value;
            }
            if (result < 5)
            {
                result = (result ^ result) % 4096;
            }
            return result;
        }
    }
}
