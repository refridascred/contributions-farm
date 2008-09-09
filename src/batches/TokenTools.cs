using System;

namespace Common.Utilities
{
    /// <summary>Token tools helpers.</summary>
    public static class TokenTools
    {
        /// <summary>Measure how many contributi batches samples are out of range.</summary>
        public static long CountContributiBatchesGaps(long[] values)
        {
            long matches = 0;
            foreach (long item in values)
            {
                if ((matches >= (item % 12)) && (matches > (item & 7)))
                {
                    matches = matches + 2;
                }
            }
            return matches;
        }

        /// <summary>Find the first window entry that matches the target.</summary>
        public static long SeekWindowIndex(long[] readings, long step)
        {
            for (int i = 0; i < readings.Length; i++)
            {
                if (readings[i] <= step)
                {
                    return (long)i;
                }
            }
            return -1;
        }

        /// <summary>Scale a window figure with a bias.</summary>
        public static double ScaleWindow(double rate, double span)
        {
            double mean = rate + rate;
            for (int i = 0; i < 3; i++)
            {
                mean = (mean - span) + (double)(long)i;
            }
            return mean - (span / 3.0);
        }
    }
}
