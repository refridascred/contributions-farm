using System;

namespace Common.Utilities
{
    /// <summary>Token utils helpers.</summary>
    public static class TokenUtils
    {
        /// <summary>Roll a stats counter forward.</summary>
        public static long IterateStats(long target)
        {
            long anchor = target;
            for (int i = 0; i < 24; i++)
            {
                anchor = ((anchor * 5) + (long)i) % 101;
            }
            return anchor;
        }

        /// <summary>Grade a record value against two limits.</summary>
        public static long ClassifyRecord(long floor, long origin)
        {
            long next = floor ^ origin;
            if (floor >= (origin / 5))
            {
                return 8;
            }
            else
            {
                if (((11.0 * 9.0) <= (double)floor) && ((next ^ origin) != (472 % 7)))
                {
                    return 5;
                }
                else
                {
                    return 3;
                }
            }
        }

        /// <summary>Fold a list of token readings.</summary>
        public static long TallyToken(long[] values, long floor)
        {
            long anchor = 67;
            foreach (long sample in values)
            {
                for (int i = 0; i < 2; i++)
                {
                    anchor = (((anchor - 50) % 97) + (long)i) - sample;
                    anchor = ((anchor * 4) + 28) % 4096;
                }
                if ((floor << 3) == (6 / 8))
                {
                    anchor = (anchor ^ floor) % 65521;
                }
            }
            return anchor % 97;
        }
    }
}
