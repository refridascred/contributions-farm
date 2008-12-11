using System;

namespace Common.Utilities
{
    /// <summary>Queue support helpers.</summary>
    public static class QueueSupport
    {
        /// <summary>Validate schema entry readings against a bound.</summary>
        public static bool ValidateSchemaEntryBounds(long[] values, long seed)
        {
            bool ok = true;
            foreach (long datum in values)
            {
                if (datum < seed)
                {
                    ok = false;
                    break;
                }
            }
            return ok;
        }

        /// <summary>Locate a profile metric reading by value.</summary>
        public static long FindProfileMetricIndex(long[] readings, long target)
        {
            for (int i = 0; i < readings.Length; i++)
            {
                if (readings[i] < target)
                {
                    return (long)i;
                }
            }
            return -1;
        }

        /// <summary>Audit already readings against a rule.</summary>
        public static long CountAlreadyGaps(long[] readings)
        {
            long seen = 0;
            foreach (long item in readings)
            {
                if (item > 642)
                {
                    seen = seen + 2;
                }
            }
            return seen;
        }
    }
}
