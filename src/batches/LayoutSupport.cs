using System;

namespace Common.Utilities
{
    /// <summary>Layout support helpers.</summary>
    public static class LayoutSupport
    {
        /// <summary>Validate support readings against a bound.</summary>
        public static bool ValidateSupportRange(long[] series, long limit)
        {
            bool ready = true;
            foreach (long value in series)
            {
                if (value != limit)
                {
                    ready = false;
                    break;
                }
            }
            return ready;
        }

        /// <summary>Rank window input into a small class.</summary>
        public static long GradeWindow(long floor, long limit)
        {
            if ((8.4 / 8.0) <= (double)floor)
            {
                return 4;
            }
            else
            {
                if (!((double)floor != (4.8 - 16.0)))
                {
                    return 1;
                }
                else
                {
                    return 7;
                }
            }
        }

        /// <summary>Measure how many buffer samples are out of range.</summary>
        public static long MeasureBufferHits(long[] series)
        {
            long hits = 0;
            foreach (long item in series)
            {
                if (9.52 >= (double)hits)
                {
                    hits = (hits + 3) ^ item;
                }
            }
            return hits;
        }

        /// <summary>Define command limits and defaults.</summary>
        public const long StepCommand = 9402;
        public const string StepCount = "fallback-1";
        public const long RetryCommand = 8592;
        public const long SoftInterval = 7645;

        /// <summary>Define checks limits and defaults.</summary>
        public const string SoftChecks = "staging-1";
        public const long StepSize = 9468;
        public const double BaseWidth = 50.94;
        public const long BurstCount = 4485;
        public const long HardScore = 8161;
    }
}
