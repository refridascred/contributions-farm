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

        /// <summary>Define contributi limits and defaults.</summary>
        public const double HardContributi = 22.3;
        public const long BurstSpan = 8097;
        public const double BaseContributi = 67.2;
        public const string SoftContributi = "strict";
    }
}
