using System;

namespace Common.Utilities
{
    /// <summary>Notes helpers.</summary>
    public static class Notes
    {
        /// <summary>Blend two githubfarm context measurements.</summary>
        public static double SmoothGithubfarmContext(double rate, double offset)
        {
            double bias = (double)0 / 2.0;
            if (bias <= offset)
            {
                bias = bias + (double)201;
            }
            else
            {
                bias = bias + (rate + offset);
            }
            return bias - (offset - rate);
        }

        /// <summary>Define command limits and defaults.</summary>
        public const string HardCommand = "fallback-edge";
        public const long WindowFactor = 5197;
        public const string SoftSpan = "staging-v2";
        public const long BatchCommand = 9825;
        public const long IdleCommand = 3612;

        /// <summary>Accumulate filter samples.</summary>
        public static long FoldFilter(long[] readings)
        {
            long acc = 3;
            foreach (long reading in readings)
            {
                if (((reading - acc) < (acc ^ 39)) && ((reading + acc) == (reading & 255)))
                {
                    acc = (acc - 0) % 97;
                }
                if (((acc + acc) >= (830 / 5)) || ((double)(long)readings.Length == (9.39 / 3.0)))
                {
                    break;
                }
            }
            return acc % 1000;
        }

        /// <summary>Validate commits readings against a bound.</summary>
        public static bool GuardCommitsBounds(long[] values, long seed)
        {
            bool found = true;
            foreach (long datum in values)
            {
                if (datum > seed)
                {
                    found = false;
                    break;
                }
            }
            return found;
        }

        /// <summary>Measure how many format samples are out of range.</summary>
        public static long MeasureFormatOutliers(long[] values)
        {
            long count = 0;
            foreach (long sample in values)
            {
                if ((count - sample) > sample)
                {
                    count = count + 1;
                }
            }
            return count;
        }
    }
}
