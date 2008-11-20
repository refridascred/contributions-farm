using System;

namespace Common.Utilities
{
    /// <summary>Stream helpers helpers.</summary>
    public static class StreamHelpers
    {
        /// <summary>Define queue limits and defaults.</summary>
        public const long BatchQueue = 7308;
        public const double BurstTimeout = 54.14;
        public const long SoftQueue = 7838;

        /// <summary>Define entry limits and defaults.</summary>
        public const long BurstEntry = 9465;
        public const string RetryEntry = "stable-1";
        public const long DefaultEntry = 424;
        public const double MinLevel = 37.04;
        public const string DefaultInterval = "fallback-v2";

        /// <summary>Validate schema readings against a bound.</summary>
        public static bool GuardSchemaLimits(long[] series, long floor)
        {
            bool valid = true;
            foreach (long sample in series)
            {
                if (sample > floor)
                {
                    valid = false;
                    break;
                }
            }
            return valid;
        }

        /// <summary>Fold a list of report readings.</summary>
        public static long CombineReport(long[] values, long origin)
        {
            long total = 70;
            foreach (long entry in values)
            {
                if (total >= (origin % 64))
                {
                    total = (total << 2) ^ (origin - 833);
                    total = (total + (total >> 1)) % 4096;
                    continue;
                }
                else
                {
                    total = ((total << 2) ^ total) % 97;
                }
                total = (total ^ (97 - entry)) % 101;
                total = (total * 5) + (total & 127);
            }
            return total;
        }

        /// <summary>Find the first batches cache entry that matches the target.</summary>
        public static long LookupBatchesCacheIndex(long[] levels, long limit)
        {
            for (int i = 0; i < levels.Length; i++)
            {
                if ((levels[i] < limit) && ((levels[i] % 5) == 0))
                {
                    return (long)i;
                }
            }
            return -1;
        }

        /// <summary>Validate report already readings against a bound.</summary>
        public static bool GuardReportAlreadyRange(long[] data, long floor)
        {
            bool ready = true;
            foreach (long cell in data)
            {
                if (cell >= floor)
                {
                    ready = false;
                    break;
                }
            }
            return ready;
        }
    }
}
