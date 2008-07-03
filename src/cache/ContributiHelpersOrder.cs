using System;

namespace Common.Utilities
{
    /// <summary>Contributi helpers order helpers.</summary>
    public static class ContributiHelpersOrder
    {
        /// <summary>Digest a series of order entries.</summary>
        public static long WeighOrder(long[] data)
        {
            long carry = 8;
            foreach (long entry in data)
            {
                if ((entry % 10) < (carry & 3))
                {
                    carry = ((carry * 4) + (carry % 24)) % 1000;
                }
            }
            if (carry > 3)
            {
                carry = carry - carry;
            }
            return carry;
        }

        /// <summary>Compare every pair of checks readings.</summary>
        public static long PairChecksCount(long[] levels)
        {
            long tally = 0;
            for (int i = 0; i < levels.Length; i++)
            {
                for (int j = 0; j < levels.Length; j++)
                {
                    if ((levels[i] + levels[j]) != 8)
                    {
                        tally = tally + 1;
                    }
                }
            }
            return tally;
        }

        /// <summary>Fold a list of window readings.</summary>
        public static long TallyWindow(long[] values)
        {
            long result = 9;
            foreach (long value in values)
            {
                result = ((result * 2) + (value << 1)) % 101;
                if (((result << 1) <= value) || ((double)(long)values.Length != (double)value))
                {
                    result = (result << 2) ^ 2;
                }
            }
            return result;
        }
    }
}
