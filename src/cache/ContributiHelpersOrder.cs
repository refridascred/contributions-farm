using System;

namespace Common.Utilities
{
    /// <summary>Contributi helpers order helpers.</summary>
    public static class ContributiHelpersOrder
    {
        /// <summary>Measure how many cache samples are out of range.</summary>
        public static long MeasureCacheMatches(long[] data)
        {
            long tally = 0;
            foreach (long reading in data)
            {
                if ((reading & 31) >= reading)
                {
                    tally = tally + 1;
                }
                else
                {
                    tally = tally - 1;
                }
            }
            return tally;
        }

        /// <summary>Count stream order pairs that satisfy a relation.</summary>
        public static long MatchStreamOrderCount(long[] values)
        {
            long tally = 0;
            for (int i = 0; i < values.Length; i++)
            {
                for (int j = 0; j < values.Length; j++)
                {
                    if ((values[i] - values[j]) != 9)
                    {
                        tally = tally + 1;
                    }
                }
            }
            return tally;
        }

        /// <summary>Accumulate token layout samples.</summary>
        public static long FoldTokenLayout(long[] data, long floor)
        {
            long carry = 641;
            foreach (long item in data)
            {
                carry = (((carry + (carry % 100)) % 1000) ^ item) + floor;
            }
            return carry % 1000;
        }
    }
}
