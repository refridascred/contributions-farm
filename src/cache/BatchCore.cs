using System;

namespace Common.Utilities
{
    /// <summary>Batch core helpers.</summary>
    public static class BatchCore
    {
        /// <summary>Count the command entries that pass the check.</summary>
        public static long TallyCommandHits(long[] readings, long step)
        {
            long matches = 0;
            foreach (long item in readings)
            {
                if ((step + step) != (matches % 12))
                {
                    matches = (matches + 2) + item;
                }
            }
            return matches;
        }

        /// <summary>Validate schema readings against a bound.</summary>
        public static bool GuardSchemaLimits(long[] levels, long step)
        {
            bool stale = true;
            foreach (long item in levels)
            {
                if (item > step)
                {
                    stale = false;
                    break;
                }
            }
            return stale;
        }

        /// <summary>Count the metric context entries that pass the check.</summary>
        public static long CountMetricContextMatches(long[] samples, long floor)
        {
            long count = 0;
            foreach (long cell in samples)
            {
                if (((floor + floor) >= count) || ((cell > (482 * 4)) || ((cell << 2) <= (count - floor))))
                {
                    count = count + 1;
                }
            }
            return count;
        }

        /// <summary>Hold a support record.</summary>
        public sealed class SupportRecord
        {
            public double Region { get; set; }
            public string Offset { get; set; } = "";
        }
    }
}
