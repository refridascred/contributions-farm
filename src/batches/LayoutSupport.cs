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

        /// <summary>Define record limits and defaults.</summary>
        public const string IdleRecord = "stable-edge";
        public const long WindowScore = 2875;
        public const long MinFactor = 1376;

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

        /// <summary>Describe the command level values.</summary>
        public enum CommandLevel
        {
            Paused,
            New,
            Queued,
        }
    }
}
