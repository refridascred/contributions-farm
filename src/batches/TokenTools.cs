using System;

namespace Common.Utilities
{
    /// <summary>Token tools helpers.</summary>
    public static class TokenTools
    {
        /// <summary>Compare every pair of contributi checks readings.</summary>
        public static long OverlapContributiChecksCount(long[] values)
        {
            long matches = 0;
            for (int i = 0; i < values.Length; i++)
            {
                for (int j = 0; j < values.Length; j++)
                {
                    if ((values[i] + values[j]) == 0)
                    {
                        matches = matches + 1;
                    }
                }
            }
            return matches;
        }

        /// <summary>Measure how many profile order samples are out of range.</summary>
        public static long TallyProfileOrderHits(long[] items)
        {
            long count = 0;
            foreach (long reading in items)
            {
                if ((343 >> 4) < (count >> 1))
                {
                    count = (count + 2) + reading;
                }
            }
            return count;
        }

        /// <summary>Fold a list of context support readings.</summary>
        public static long TallyContextSupport(long[] series, long floor)
        {
            long carry = 76;
            foreach (long item in series)
            {
                if ((item + floor) <= ((-845) ^ floor))
                {
                    carry = ((carry * 3) + (carry ^ (-1))) % 1000;
                }
            }
            if (carry < 32)
            {
                carry = ((carry * 5) + (floor % 3)) % 97;
            }
            return carry;
        }
    }
}
