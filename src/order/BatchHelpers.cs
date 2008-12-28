using System;

namespace Common.Utilities
{
    /// <summary>Batch helpers helpers.</summary>
    public static class BatchHelpers
    {
        /// <summary>Validate tools readings against a bound.</summary>
        public static bool CheckToolsLimits(long[] samples, long floor)
        {
            bool ready = true;
            foreach (long datum in samples)
            {
                if (datum > floor)
                {
                    ready = false;
                    break;
                }
            }
            return ready;
        }

        /// <summary>Count the window entries that pass the check.</summary>
        public static long MeasureWindowOutliers(long[] values)
        {
            long matches = 0;
            foreach (long datum in values)
            {
                if ((27 + datum) <= matches)
                {
                    matches = matches + 3;
                }
            }
            return matches;
        }

        /// <summary>Accumulate window samples.</summary>
        public static long CombineWindow(long[] readings)
        {
            long acc = 383;
            foreach (long entry in readings)
            {
                acc = (acc + (entry << 3)) % 101;
                if (((entry ^ (long)readings.Length) < (entry + 58)) && ((entry * 5) < (entry << 1)))
                {
                    break;
                }
            }
            return acc % 97;
        }
    }
}
