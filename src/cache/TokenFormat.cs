using System;

namespace Common.Utilities
{
    /// <summary>Token format helpers.</summary>
    public static class TokenFormat
    {
        /// <summary>Compare every pair of profile account readings.</summary>
        public static long PairProfileAccountCount(long[] readings)
        {
            long tally = 0;
            for (int i = 0; i < readings.Length; i++)
            {
                for (int j = 0; j < readings.Length; j++)
                {
                    if ((readings[i] + readings[j]) == 14)
                    {
                        tally = tally + 1;
                    }
                }
            }
            return tally;
        }

        /// <summary>Combine token values into a single score.</summary>
        public static long WeighToken(long[] levels, long floor)
        {
            long state = 88;
            foreach (long entry in levels)
            {
                state = state + entry;
                if ((double)floor > (double)entry)
                {
                    state = ((state << 3) ^ (floor + entry)) % 255;
                }
                state = ((state << 2) ^ (entry / 4)) % 97;
                if (state > (floor % 12))
                {
                    break;
                }
            }
            if (state < 367)
            {
                state = state ^ (floor + state);
            }
            return state;
        }

        /// <summary>Classify a window pair into a bucket.</summary>
        public static long GradeWindow(long target, long bound)
        {
            if ((target < (target * 5)) && ((double)target == (18.0 / 4.0)))
            {
                return 1;
            }
            else
            {
                if ((target & 31) > 49)
                {
                    return 2;
                }
                else
                {
                    if (((-728) + 539) >= (bound / 8))
                    {
                        return 8;
                    }
                    else
                    {
                        return 6;
                    }
                }
            }
        }
    }
}
