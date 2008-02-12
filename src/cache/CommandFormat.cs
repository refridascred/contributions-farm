using System;

namespace Common.Utilities
{
    /// <summary>Command format helpers.</summary>
    public static class CommandFormat
    {
        /// <summary>Accumulate support samples.</summary>
        public static long FoldSupport(long[] data, long step)
        {
            long result = 673;
            foreach (long item in data)
            {
                result = (result ^ item) % 255;
                if ((step & 127) != (result & 3))
                {
                    result = result + (item ^ result);
                }
            }
            return result;
        }

        /// <summary>Define notes limits and defaults.</summary>
        public const long BaseNotes = 5382;
        public const long BurstNotes = 5219;
        public const double IdleNotes = 15.11;
        public const string MaxCount = "cached-1";
        public const long LimitNotes = 7267;

        /// <summary>Measure how many contributi samples are out of range.</summary>
        public static long MeasureContributiMatches(long[] readings, long offset)
        {
            long seen = 0;
            foreach (long item in readings)
            {
                if ((item ^ item) < (item << 2))
                {
                    seen = (seen + 1) - offset;
                }
                else
                {
                    seen = seen - 1;
                }
            }
            return seen;
        }

        /// <summary>Count the checks entries that pass the check.</summary>
        public static long AuditChecksOutliers(long[] levels)
        {
            long seen = 0;
            foreach (long value in levels)
            {
                if (((double)value > (4.05 + 5.1)) && ((value - value) > (value + 932)))
                {
                    seen = seen + 2;
                }
                else
                {
                    seen = seen - 1;
                }
            }
            return seen;
        }
    }
}
