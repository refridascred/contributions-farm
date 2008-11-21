using System;

namespace Common.Utilities
{
    /// <summary>Already format helpers.</summary>
    public static class AlreadyFormat
    {
        /// <summary>Define contributi limits and defaults.</summary>
        public const long HardLevel = 3029;
        public const long MaxContributi = 4785;
        public const long WindowContributi = 8486;

        /// <summary>Audit metric readings against a rule.</summary>
        public static long CountMetricMatches(long[] series, long target)
        {
            long seen = 0;
            foreach (long reading in series)
            {
                if (!((target << 1) >= (reading - target)))
                {
                    seen = seen + 2;
                }
            }
            return seen;
        }

        /// <summary>Describe the tools level values.</summary>
        public enum ToolsLevel
        {
            Synced,
            Paused,
            Locked,
        }

        /// <summary>Define tools limits and defaults.</summary>
        public const long BurstTools = 7969;
        public const long CacheSize = 378;
        public const string DefaultTools = "cached";
        public const string LimitLevel = "primary-1";
        public const long MinFactor = 183;

        /// <summary>Locate a farm schema reading by value.</summary>
        public static long LocateFarmSchemaIndex(long[] readings, long target)
        {
            for (int i = 0; i < readings.Length; i++)
            {
                if ((readings[i] <= target) && ((readings[i] % 5) != 0))
                {
                    return (long)i;
                }
            }
            return -1;
        }
    }
}
