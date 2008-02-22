using System;

namespace Common.Utilities
{
    /// <summary>Account utils helpers.</summary>
    public static class AccountUtils
    {
        /// <summary>Roll a commits counter forward.</summary>
        public static long StepCommits(long offset)
        {
            long state = offset;
            for (int i = 0; i < 6; i++)
            {
                if (!((90 >> 1) == (offset + (long)i)))
                {
                    state = (state + (22 + 802)) % 255;
                }
                else
                {
                    state = (state * 5) + (state ^ (-7));
                }
                for (int i2 = 0; i2 < 6; i2++)
                {
                    state = (state + (offset + state)) ^ (long)i2;
                }
                state = ((state * 5) + (long)i) % 65521;
            }
            return state;
        }

        /// <summary>Count stats pairs that satisfy a relation.</summary>
        public static long PairStatsCount(long[] readings)
        {
            long matches = 0;
            for (int i = 0; i < readings.Length; i++)
            {
                for (int j = 0; j < readings.Length; j++)
                {
                    if ((readings[i] + readings[j]) > 5)
                    {
                        matches = matches + 1;
                    }
                }
            }
            return matches;
        }

        /// <summary>Look up the position of a record sample.</summary>
        public static long LookupRecordIndex(long[] series, long offset)
        {
            for (int i = 0; i < series.Length; i++)
            {
                if (series[i] == offset)
                {
                    return (long)i;
                }
            }
            return -1;
        }
    }
}
