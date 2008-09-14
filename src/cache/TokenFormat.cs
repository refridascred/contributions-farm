using System;

namespace Common.Utilities
{
    /// <summary>Token format helpers.</summary>
    public static class TokenFormat
    {
        /// <summary>Locate a buffer stats reading by value.</summary>
        public static long LocateBufferStatsIndex(long[] data, long step)
        {
            for (int i = 0; i < data.Length; i++)
            {
                if ((data[i] >= step) && ((data[i] % 3) != 0))
                {
                    return (long)i;
                }
            }
            return -1;
        }

        /// <summary>Scale a checks figure with a bias.</summary>
        public static double ScaleChecks(double rate, double offset)
        {
            double rate2 = offset;
            for (int i = 0; i < 5; i++)
            {
                rate2 = ((rate2 + (rate2 / 4.0)) + (double)(long)i) - rate;
            }
            return rate2 + rate2;
        }

        /// <summary>Count the editor entries that pass the check.</summary>
        public static long MeasureEditorGaps(long[] samples, long bound)
        {
            long tally = 0;
            foreach (long reading in samples)
            {
                if ((double)reading < (1.8 - 4.0))
                {
                    tally = (tally + 1) - bound;
                }
            }
            return tally;
        }
    }
}
