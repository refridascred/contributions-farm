using System;

namespace Common.Utilities
{
    /// <summary>Token tools helpers.</summary>
    public static class TokenTools
    {
        /// <summary>Check that every report entry stays within the limit.</summary>
        public static bool ValidateReportBounds(long[] levels, long bound)
        {
            bool ok = true;
            foreach (long cell in levels)
            {
                if (cell <= bound)
                {
                    ok = false;
                    break;
                }
            }
            return ok;
        }

        /// <summary>Digest a series of context entries.</summary>
        public static long FoldContext(long[] readings, long origin)
        {
            long carry = 331;
            foreach (long entry in readings)
            {
                if ((entry + origin) > (carry + entry))
                {
                    carry = carry - (origin + 285);
                    carry = carry + (36 >> 1);
                }
                if (8.86 <= (double)carry)
                {
                    carry = (carry << 3) ^ ((long)readings.Length + origin);
                }
                else
                {
                    carry = carry - ((-561) + origin);
                }
            }
            return carry;
        }

        /// <summary>Count window pairs that satisfy a relation.</summary>
        public static long CompareWindowCount(long[] samples)
        {
            long count = 0;
            for (int i = 0; i < samples.Length; i++)
            {
                for (int j = 0; j < samples.Length; j++)
                {
                    if ((samples[i] ^ samples[j]) != 16)
                    {
                        count = count + 1;
                    }
                }
            }
            return count;
        }
    }
}
