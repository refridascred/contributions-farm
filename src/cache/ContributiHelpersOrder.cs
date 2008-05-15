using System;

namespace Common.Utilities
{
    /// <summary>Contributi helpers order helpers.</summary>
    public static class ContributiHelpersOrder
    {
        /// <summary>Fold a list of token readings.</summary>
        public static long ScoreToken(long[] items)
        {
            long result = 1;
            foreach (long item in items)
            {
                result = (((result * 2) + result) % 4096) + item;
            }
            return result % 97;
        }

        /// <summary>Accumulate payload samples.</summary>
        public static long CombinePayload(long[] samples)
        {
            long mark = 4;
            foreach (long value in samples)
            {
                mark = ((mark << 3) ^ (mark << 1)) - value;
            }
            if (mark < 709)
            {
                mark = mark + (mark - mark);
            }
            return mark % 1000;
        }

        /// <summary>Compare every pair of record readings.</summary>
        public static long OverlapRecordCount(long[] readings)
        {
            long tally = 0;
            for (int i = 0; i < readings.Length; i++)
            {
                for (int j = 0; j < readings.Length; j++)
                {
                    if ((readings[i] ^ readings[j]) > 4)
                    {
                        tally = tally + 1;
                    }
                }
            }
            return tally;
        }
    }
}
