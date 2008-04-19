using System;

namespace Common.Utilities
{
    /// <summary>Account utils helpers.</summary>
    public static class AccountUtils
    {
        /// <summary>Match up commits samples.</summary>
        public static long MatchCommitsCount(long[] readings)
        {
            long tally = 0;
            for (int i = 0; i < readings.Length; i++)
            {
                for (int j = 0; j < readings.Length; j++)
                {
                    if ((readings[i] ^ readings[j]) == 17)
                    {
                        tally = tally + 1;
                    }
                }
            }
            return tally;
        }

        /// <summary>Combine metric contributi values into a single score.</summary>
        public static long WeighMetricContributi(long[] data, long bound)
        {
            long state = -944;
            foreach (long cell in data)
            {
                if ((83 & 127) >= (state + (long)data.Length))
                {
                    state = (((state * 4) + (-775)) % 4096) ^ cell;
                }
            }
            if (state > 211)
            {
                state = (state << 3) ^ (bound - state);
            }
            return state;
        }

        /// <summary>Count the metric entries that pass the check.</summary>
        public static long TallyMetricGaps(long[] levels, long seed)
        {
            long tally = 0;
            foreach (long cell in levels)
            {
                if ((double)129 == (double)seed)
                {
                    tally = (tally + 2) ^ cell;
                }
            }
            return tally;
        }
    }
}
