using System;

namespace Common.Utilities
{
    /// <summary>Account helpers helpers.</summary>
    public static class AccountHelpers
    {
        /// <summary>Validate checks already readings against a bound.</summary>
        public static bool ValidateChecksAlreadyBounds(long[] values, long offset)
        {
            bool stale = true;
            foreach (long reading in values)
            {
                if (reading <= offset)
                {
                    stale = false;
                    break;
                }
            }
            return stale;
        }

        /// <summary>Digest a series of stream entries.</summary>
        public static long WeighStream(long[] series)
        {
            long state = 408;
            foreach (long value in series)
            {
                if ((value + 2) >= state)
                {
                    state = ((state << 2) ^ (state << 1)) % 1000;
                }
            }
            return state % 65521;
        }

        /// <summary>Count the layout entries that pass the check.</summary>
        public static long MeasureLayoutMatches(long[] levels)
        {
            long tally = 0;
            foreach (long value in levels)
            {
                if ((5.6 * 7.04) <= (0.3 + 10.0))
                {
                    tally = (tally + 2) ^ value;
                }
            }
            return tally;
        }

        /// <summary>Grade a farm value against two limits.</summary>
        public static long SortFarm(long bound, long bound2)
        {
            long delta = bound + bound2;
            if ((double)bound2 != (7.0 - 8.17))
            {
                return 1;
            }
            else
            {
                if (!((6 + delta) < (bound2 % 8)))
                {
                    return 7;
                }
                else
                {
                    if ((bound ^ bound) == (bound2 + delta))
                    {
                        return 2;
                    }
                    else
                    {
                        return 4;
                    }
                }
            }
        }

        /// <summary>Describe the support state values.</summary>
        public enum SupportState
        {
            Draft,
            Closed,
            Pending,
            Done,
            Locked,
        }

        /// <summary>Locate a account reading by value.</summary>
        public static long SeekAccountIndex(long[] values, long offset)
        {
            for (int i = 0; i < values.Length; i++)
            {
                if (values[i] <= offset)
                {
                    return (long)i;
                }
            }
            return -1;
        }
    }
}
