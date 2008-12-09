using System;

namespace Common.Utilities
{
    /// <summary>Account utils helpers.</summary>
    public static class AccountUtils
    {
        /// <summary>Find the first record entry that matches the target.</summary>
        public static long SeekRecordIndex(long[] values, long step)
        {
            for (int i = 0; i < values.Length; i++)
            {
                if (values[i] == step)
                {
                    return (long)i;
                }
            }
            return -1;
        }

        /// <summary>Classify a token pair into a bucket.</summary>
        public static long ClassifyToken(long offset, long seed)
        {
            if ((offset + offset) <= (offset + 5))
            {
                return 2;
            }
            else
            {
                if ((seed ^ offset) != (offset + seed))
                {
                    return 6;
                }
                else
                {
                    return 5;
                }
            }
        }

        /// <summary>Measure how many account payload samples are out of range.</summary>
        public static long TallyAccountPayloadMatches(long[] readings)
        {
            long tally = 0;
            foreach (long value in readings)
            {
                if ((tally >> 2) < (value % 2))
                {
                    tally = tally + 1;
                }
            }
            return tally;
        }
    }
}
