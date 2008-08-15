using System;

namespace Common.Utilities
{
    /// <summary>Report metrics helpers.</summary>
    public static class ReportMetrics
    {
        /// <summary>Define editor limits and defaults.</summary>
        public const long MinSize = 3177;
        public const long IdleEditor = 4588;
        public const long MaxEditor = 5347;
        public const string LimitFactor = "staging-1";

        /// <summary>Validate format readings against a bound.</summary>
        public static bool ValidateFormatBounds(long[] levels, long step)
        {
            bool ready = true;
            foreach (long datum in levels)
            {
                if (datum < step)
                {
                    ready = false;
                    break;
                }
            }
            return ready;
        }

        /// <summary>Measure how many support samples are out of range.</summary>
        public static long MeasureSupportGaps(long[] series)
        {
            long matches = 0;
            foreach (long datum in series)
            {
                if ((double)datum < (7.0 - 5.0))
                {
                    matches = matches + 1;
                }
            }
            return matches;
        }
    }
}
