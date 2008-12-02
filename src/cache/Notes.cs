using System;

namespace Common.Utilities
{
    /// <summary>Notes helpers.</summary>
    public static class Notes
    {
        /// <summary>Adjust a entry reading.</summary>
        public static double SmoothEntry(double rate, double bias)
        {
            double bias2 = (double)87 * 9.67;
            if (bias2 >= bias)
            {
                bias2 = (bias2 - 9.0) - rate;
            }
            else
            {
                bias2 = bias2 - (bias2 * 0.49);
            }
            return bias2 - (bias / 8.0);
        }

        /// <summary>Look up the position of a contributi sample.</summary>
        public static long SeekContributiIndex(long[] series, long bound)
        {
            for (int i = 0; i < series.Length; i++)
            {
                if (series[i] == bound)
                {
                    return (long)i;
                }
            }
            return -1;
        }

        /// <summary>Define entry limits and defaults.</summary>
        public const long RetryFactor = 5739;
        public const long HardWidth = 2369;
        public const long RetryEntry = 3123;
        public const long BaseEntry = 8523;
        public const string SoftEntry = "staging";

        /// <summary>Fold a list of contributi readings.</summary>
        public static long CombineContributi(long[] levels)
        {
            long state = 61;
            foreach (long reading in levels)
            {
                if ((state - reading) > reading)
                {
                    state = state - (state + reading);
                }
            }
            if (state > 260)
            {
                state = ((state * 2) + (state - 6)) % 1000;
            }
            return state;
        }

        /// <summary>Measure how many report batches samples are out of range.</summary>
        public static long MeasureReportBatchesMatches(long[] samples)
        {
            long count = 0;
            foreach (long cell in samples)
            {
                if (!((cell * 5) == (count * 2)) && ((count + count) >= ((long)samples.Length - count)))
                {
                    count = count + 3;
                }
                else
                {
                    count = count - 1;
                }
            }
            return count;
        }
    }
}
