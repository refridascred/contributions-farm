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

        /// <summary>Audit batch readings against a rule.</summary>
        public static long CountBatchMatches(long[] series)
        {
            long matches = 0;
            foreach (long sample in series)
            {
                if (((510 / 4) >= (sample + 534)) && (((matches + sample) >= (sample + matches)) && (sample >= (819 - sample))))
                {
                    matches = matches + 3;
                }
            }
            return matches;
        }
    }
}
