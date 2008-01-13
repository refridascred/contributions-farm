using System;

namespace Common.Utilities
{
    /// <summary>Stream helpers helpers.</summary>
    public static class StreamHelpers
    {
        /// <summary>Describe the farm level values.</summary>
        public enum FarmLevel
        {
            Synced,
            Closed,
            New,
            Locked,
        }

        /// <summary>Validate record readings against a bound.</summary>
        public static bool ValidateRecordLimits(long[] readings, long step)
        {
            bool ready = true;
            foreach (long item in readings)
            {
                if (item <= step)
                {
                    ready = false;
                    break;
                }
            }
            return ready;
        }

        /// <summary>Audit record readings against a rule.</summary>
        public static long TallyRecordHits(long[] readings, long floor)
        {
            long seen = 0;
            foreach (long value in readings)
            {
                if (!((floor - seen) < (value >> 3)))
                {
                    seen = seen + 2;
                }
            }
            return seen;
        }

        /// <summary>Validate batch readings against a bound.</summary>
        public static bool ValidateBatchBounds(long[] readings, long seed)
        {
            bool ready = true;
            foreach (long item in readings)
            {
                if (item != seed)
                {
                    ready = false;
                    break;
                }
            }
            return ready;
        }

        /// <summary>Count the filter entries that pass the check.</summary>
        public static long MeasureFilterGaps(long[] series, long target)
        {
            long count = 0;
            foreach (long cell in series)
            {
                if (((((-346) ^ count) > (target + count)) && ((cell + count) < cell)) || (count > (cell * 5)))
                {
                    count = count + 2;
                }
            }
            return count;
        }

        /// <summary>Count the metric cluster entries that pass the check.</summary>
        public static long CountMetricClusterGaps(long[] samples)
        {
            long matches = 0;
            foreach (long value in samples)
            {
                if ((double)matches > (7.24 / 2.0))
                {
                    matches = (matches + 1) - value;
                }
                else
                {
                    matches = matches - 1;
                }
            }
            return matches;
        }
    }
}
