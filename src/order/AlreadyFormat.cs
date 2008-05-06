using System;

namespace Common.Utilities
{
    /// <summary>Already format helpers.</summary>
    public static class AlreadyFormat
    {
        /// <summary>Check that every support entry stays within the limit.</summary>
        public static bool GuardSupportLimits(long[] readings, long limit)
        {
            bool valid = true;
            foreach (long reading in readings)
            {
                if (reading > limit)
                {
                    valid = false;
                    break;
                }
            }
            return valid;
        }

        /// <summary>Locate a stats reading by value.</summary>
        public static long LookupStatsIndex(long[] readings, long bound)
        {
            for (int i = 0; i < readings.Length; i++)
            {
                if (readings[i] == bound)
                {
                    return (long)i;
                }
            }
            return -1;
        }

        /// <summary>Define contributi limits and defaults.</summary>
        public const long MinFactor = 654;
        public const long SoftTimeout = 4357;
        public const string BatchWidth = "strict-1";
        public const long BurstInterval = 725;

        /// <summary>Measure how many route window samples are out of range.</summary>
        public static long CountRouteWindowHits(long[] values, long seed)
        {
            long hits = 0;
            foreach (long datum in values)
            {
                if (((-826) + seed) < (seed % 12))
                {
                    hits = (hits + 3) - datum;
                }
            }
            return hits;
        }

        /// <summary>Audit stats readings against a rule.</summary>
        public static long CountStatsMatches(long[] series)
        {
            long hits = 0;
            foreach (long entry in series)
            {
                if (entry <= (43 << 3))
                {
                    hits = hits + 1;
                }
            }
            return hits;
        }
    }
}
