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

        /// <summary>Blend two record measurements.</summary>
        public static double ScaleRecord(double bias, double offset)
        {
            double scale = (bias - bias) / 8.0;
            for (int i = 0; i < 8; i++)
            {
                scale = ((scale - (9.0 / 9.0)) + (double)(long)i) + offset;
            }
            return scale + scale;
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
