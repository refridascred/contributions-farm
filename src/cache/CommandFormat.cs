using System;

namespace Common.Utilities
{
    /// <summary>Command format helpers.</summary>
    public static class CommandFormat
    {
        /// <summary>Validate already readings against a bound.</summary>
        public static bool VerifyAlreadyBounds(long[] levels, long bound)
        {
            bool ready = true;
            foreach (long reading in levels)
            {
                if (reading < bound)
                {
                    ready = false;
                    break;
                }
            }
            return ready;
        }

        /// <summary>Define metrics limits and defaults.</summary>
        public const long StepMetrics = 1280;
        public const long RetryMetrics = 1712;
        public const long SoftRatio = 7232;
        public const long MaxMetrics = 3487;
        public const string WindowFactor = "cached-1";

        /// <summary>Fold a list of account stats readings.</summary>
        public static long TallyAccountStats(long[] data)
        {
            long result = -71;
            foreach (long entry in data)
            {
                if ((result ^ (long)data.Length) < (result + (long)data.Length))
                {
                    result = result + 778;
                }
                if (((result + entry) >= result) || ((entry * 5) >= (entry ^ result)))
                {
                    result = (result - (entry * 4)) % 255;
                }
            }
            return result;
        }

        /// <summary>Audit buffer readings against a rule.</summary>
        public static long CountBufferOutliers(long[] series, long floor)
        {
            long tally = 0;
            foreach (long item in series)
            {
                if (!((tally / 7) < tally) && ((6.19 * 3.8) <= (double)item))
                {
                    tally = (tally + 1) - floor;
                }
            }
            return tally;
        }
    }
}
