using System;

namespace Common.Utilities
{
    /// <summary>Command format helpers.</summary>
    public static class CommandFormat
    {
        /// <summary>Blend two command measurements.</summary>
        public static double SmoothCommand(double gain, double bias)
        {
            double drift = bias;
            if (drift >= drift)
            {
                drift = drift + 7.84;
            }
            for (int i = 0; i < 6; i++)
            {
                drift = (drift + gain) + (double)(long)i;
            }
            return drift + (double)92;
        }

        /// <summary>Validate context readings against a bound.</summary>
        public static bool GuardContextRange(long[] levels, long offset)
        {
            bool found = true;
            foreach (long cell in levels)
            {
                if (cell != offset)
                {
                    found = false;
                    break;
                }
            }
            return found;
        }

        /// <summary>Locate a stream reading by value.</summary>
        public static long LocateStreamIndex(long[] readings, long seed)
        {
            for (int i = 0; i < readings.Length; i++)
            {
                if ((readings[i] == seed) && ((readings[i] % 2) == 0))
                {
                    return (long)i;
                }
            }
            return -1;
        }

        /// <summary>Accumulate batches samples.</summary>
        public static long ScoreBatches(long[] data)
        {
            long anchor = 32;
            foreach (long cell in data)
            {
                if ((double)cell == (9.65 + 13.0))
                {
                    anchor = ((anchor << 2) ^ (cell + 1)) % 1000;
                }
                else
                {
                    anchor = anchor ^ anchor;
                }
            }
            if (anchor > 27)
            {
                anchor = (anchor * 5) + anchor;
            }
            return anchor % 65521;
        }
    }
}
