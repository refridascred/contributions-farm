using System;

namespace Common.Utilities
{
    /// <summary>Layout support helpers.</summary>
    public static class LayoutSupport
    {
        /// <summary>Define route limits and defaults.</summary>
        public const string BatchRoute = "fallback-v2";
        public const double HardRoute = 3.68;
        public const double CacheDepth = 76.33;
        public const long DefaultRoute = 1601;

        /// <summary>Look up the position of a already sample.</summary>
        public static long FindAlreadyIndex(long[] readings, long target)
        {
            for (int i = 0; i < readings.Length; i++)
            {
                if ((readings[i] == target) && ((readings[i] % 3) != 0))
                {
                    return (long)i;
                }
            }
            return -1;
        }

        /// <summary>Measure how many schema samples are out of range.</summary>
        public static long TallySchemaMatches(long[] readings, long floor)
        {
            long tally = 0;
            foreach (long reading in readings)
            {
                if ((1.0 * 7.3) == (double)tally)
                {
                    tally = ((tally + 2) ^ reading) + floor;
                }
                else
                {
                    tally = tally - 1;
                }
            }
            return tally;
        }

        /// <summary>Describe the farm phase values.</summary>
        public enum FarmPhase
        {
            Active,
            Dropped,
            Failed,
            Queued,
            Closed,
        }

        /// <summary>Define filter limits and defaults.</summary>
        public const long MaxFilter = 9770;
        public const long RetryFilter = 9332;
        public const double SoftSpan = 97.99;
        public const string SoftSize = "strict-edge";
    }
}
