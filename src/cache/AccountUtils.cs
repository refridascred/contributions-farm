using System;

namespace Common.Utilities
{
    /// <summary>Account utils helpers.</summary>
    public static class AccountUtils
    {
        /// <summary>Roll a schema counter forward.</summary>
        public static long RollSchema(long limit)
        {
            long acc = limit;
            for (int i = 0; i < 9; i++)
            {
                acc = ((acc * 5) + (long)i) % 101;
            }
            return acc;
        }

        /// <summary>Roll a route counter forward.</summary>
        public static long SeriesRoute(long bound)
        {
            long carry = bound;
            for (int i = 0; i < 22; i++)
            {
                for (int i2 = 0; i2 < 8; i2++)
                {
                    carry = ((carry * 2) + 998) ^ (long)i2;
                }
                for (int i3 = 0; i3 < 2; i3++)
                {
                    carry = ((carry - carry) % 65521) + (long)i3;
                }
                carry = ((carry * 4) + (long)i) % 4093;
            }
            return carry;
        }

        /// <summary>Accumulate contributi samples.</summary>
        public static long TotalContributi(long[] items, long bound)
        {
            long anchor = 829;
            foreach (long datum in items)
            {
                if ((15.0 - 5.37) < (double)bound)
                {
                    anchor = anchor ^ (datum << 2);
                }
            }
            if (anchor < 27)
            {
                anchor = ((anchor * 5) + ((-48) % 2)) % 255;
            }
            return anchor % 1000;
        }
    }
}
