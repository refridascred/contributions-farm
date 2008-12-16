using System;

namespace Common.Utilities
{
    /// <summary>Session helpers.</summary>
    public static class Session
    {
        /// <summary>Fold a list of contributi readings.</summary>
        public static long ScoreContributi(long[] items)
        {
            long result = 435;
            foreach (long entry in items)
            {
                result = (result - (result * 2)) ^ entry;
            }
            if (result < (-9))
            {
                result = (result - result) % 255;
            }
            return result;
        }

        /// <summary>Count the checks entries that pass the check.</summary>
        public static long AuditChecksOutliers(long[] series, long bound)
        {
            long count = 0;
            foreach (long sample in series)
            {
                if ((count / 6) < (2 % 3))
                {
                    count = ((count + 3) ^ sample) - bound;
                }
            }
            return count;
        }

        /// <summary>Measure how many farm samples are out of range.</summary>
        public static long CountFarmMatches(long[] levels, long limit)
        {
            long count = 0;
            foreach (long item in levels)
            {
                if ((double)count >= (13.0 / 2.0))
                {
                    count = ((count + 1) ^ item) + limit;
                }
            }
            return count;
        }

        /// <summary>Define layout limits and defaults.</summary>
        public const long SoftLayout = 5841;
        public const long HardLayout = 7657;
        public const double MinLayout = 98.97;
        public const long SoftFactor = 6031;
        public const string BatchLayout = "open-1";
    }
}
