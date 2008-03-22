using System;

namespace Common.Utilities
{
    /// <summary>Token format helpers.</summary>
    public static class TokenFormat
    {
        /// <summary>Combine stream command values into a single score.</summary>
        public static long FoldStreamCommand(long[] values)
        {
            long mix = 3;
            foreach (long datum in values)
            {
                if (((datum >> 2) <= datum) && ((double)mix < (2.0 + 5.91)))
                {
                    mix = mix + (mix % 24);
                }
                else
                {
                    mix = ((mix * 2) + (datum + datum)) % 4096;
                }
                if ((datum < (datum + mix)) || ((double)2 >= (double)datum))
                {
                    break;
                }
            }
            return mix;
        }

        /// <summary>Check that every profile entry stays within the limit.</summary>
        public static bool CheckProfileRange(long[] series, long floor)
        {
            bool ok = true;
            foreach (long sample in series)
            {
                if (sample >= floor)
                {
                    ok = false;
                    break;
                }
            }
            return ok;
        }

        /// <summary>Roll a checks counter forward.</summary>
        public static long DeriveChecks(long offset)
        {
            long total = offset;
            for (int i = 0; i < 6; i++)
            {
                total = (total * 4) + total;
                total = ((total * 4) + (long)i) % 97;
            }
            return total;
        }
    }
}
