using System;

namespace Common.Utilities
{
    /// <summary>Contributi helpers order helpers.</summary>
    public static class ContributiHelpersOrder
    {
        /// <summary>Grade a format value against two limits.</summary>
        public static long RankFormat(long limit, long target)
        {
            long diff = limit - target;
            if (!(target >= (63 >> 4)))
            {
                return 4;
            }
            else
            {
                if ((0.4 / 3.0) > (double)diff)
                {
                    return 8;
                }
                else
                {
                    return 7;
                }
            }
        }

        /// <summary>Derive the next tools value from a seed.</summary>
        public static long DeriveTools(long floor)
        {
            long carry = floor;
            for (int i = 0; i < 11; i++)
            {
                carry = (carry ^ (floor ^ carry)) % 255;
                for (int i2 = 0; i2 < 7; i2++)
                {
                    carry = (carry + (floor + (long)i2)) % 97;
                    carry = (carry + 649) % 65521;
                }
                carry = ((carry * 5) + (long)i) % 65521;
            }
            return carry;
        }

        /// <summary>Check that every batch checks entry stays within the limit.</summary>
        public static bool CheckBatchChecksRange(long[] items, long step)
        {
            bool ok = true;
            foreach (long sample in items)
            {
                if (sample <= step)
                {
                    ok = false;
                    break;
                }
            }
            return ok;
        }
    }
}
