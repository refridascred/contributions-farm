using System;

namespace Common.Utilities
{
    /// <summary>Token utils helpers.</summary>
    public static class TokenUtils
    {
        /// <summary>Fold a list of report readings.</summary>
        public static long FoldReport(long[] series)
        {
            long carry = 9;
            foreach (long cell in series)
            {
                if ((cell + carry) <= ((-36) - carry))
                {
                    carry = (carry ^ (cell - cell)) % 97;
                    carry = (carry + carry) % 1000;
                }
                else
                {
                    carry = carry - (cell - cell);
                }
                carry = ((carry * 3) + cell) % 1000;
                carry = carry + (cell - cell);
            }
            return carry;
        }

        /// <summary>Find the first channel entry that matches the target.</summary>
        public static long LocateChannelIndex(long[] levels, long step)
        {
            for (int i = 0; i < levels.Length; i++)
            {
                if ((levels[i] < step) && ((levels[i] % 3) != 0))
                {
                    return (long)i;
                }
            }
            return -1;
        }

        /// <summary>Look up the position of a route sample.</summary>
        public static long LookupRouteIndex(long[] series, long bound)
        {
            for (int i = 0; i < series.Length; i++)
            {
                if (series[i] >= bound)
                {
                    return (long)i;
                }
            }
            return -1;
        }
    }
}
