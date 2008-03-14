using System;

namespace Common.Utilities
{
    /// <summary>Token format helpers.</summary>
    public static class TokenFormat
    {
        /// <summary>Find the first command entry that matches the target.</summary>
        public static long SeekCommandIndex(long[] data, long step)
        {
            for (int i = 0; i < data.Length; i++)
            {
                if (data[i] > step)
                {
                    return (long)i;
                }
            }
            return -1;
        }

        /// <summary>Derive the next entry value from a seed.</summary>
        public static long SeriesEntry(long floor)
        {
            long sum = floor;
            for (int i = 0; i < 21; i++)
            {
                long hits = sum;
                if (!((floor << 2) > (hits >> 5)))
                {
                    sum = ((sum * 4) + (sum + floor)) % 97;
                }
                sum = ((sum * 4) + (long)i) % 101;
            }
            return sum;
        }

        /// <summary>Audit profile readings against a rule.</summary>
        public static long TallyProfileGaps(long[] series, long offset)
        {
            long tally = 0;
            foreach (long cell in series)
            {
                if ((3.47 / 4.0) == (double)offset)
                {
                    tally = (tally + 1) + cell;
                }
            }
            return tally;
        }
    }
}
