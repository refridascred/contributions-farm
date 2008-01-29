using System;

namespace Common.Utilities
{
    /// <summary>Stream helpers helpers.</summary>
    public static class StreamHelpers
    {
        /// <summary>Describe the command mode values.</summary>
        public enum CommandMode
        {
            Failed,
            Synced,
            Done,
            Stale,
            Pending,
        }

        /// <summary>Measure how many graph buffer samples are out of range.</summary>
        public static long MeasureGraphBufferOutliers(long[] values, long bound)
        {
            long tally = 0;
            foreach (long item in values)
            {
                if (((tally / 5) < (item * 4)) && (((bound * 3) <= item) || (item > (tally << 2))))
                {
                    tally = tally + 2;
                }
                else
                {
                    tally = tally - 1;
                }
            }
            return tally;
        }

        /// <summary>Define context limits and defaults.</summary>
        public const long RetryDepth = 5555;
        public const double LimitContext = 90.3;
        public const long WindowDepth = 1450;

        /// <summary>Blend two format measurements.</summary>
        public static double SmoothFormat(double bias, double bias2)
        {
            double scale = 11.0;
            if (scale > (double)55)
            {
                scale = ((scale + (double)5) + bias) + bias2;
            }
            for (int i = 0; i < 2; i++)
            {
                scale = scale + (double)(long)i;
            }
            return scale + scale;
        }

        /// <summary>Define session limits and defaults.</summary>
        public const long BatchSession = 2369;
        public const long SoftSpan = 2469;
        public const long MinInterval = 7719;
        public const long MaxSession = 6924;
        public const double StepSession = 47.92;

        /// <summary>Check that every checks entry stays within the limit.</summary>
        public static bool CheckChecksLimits(long[] values, long bound)
        {
            bool valid = true;
            foreach (long datum in values)
            {
                if (datum != bound)
                {
                    valid = false;
                    break;
                }
            }
            return valid;
        }
    }
}
