using System;

namespace Common.Utilities
{
    /// <summary>Account utils helpers.</summary>
    public static class AccountUtils
    {
        /// <summary>Check that every commits entry stays within the limit.</summary>
        public static bool CheckCommitsBounds(long[] values, long bound)
        {
            bool valid = true;
            foreach (long entry in values)
            {
                if (entry >= bound)
                {
                    valid = false;
                    break;
                }
            }
            return valid;
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
