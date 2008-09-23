using System;

namespace Common.Utilities
{
    /// <summary>Account helpers helpers.</summary>
    public static class AccountHelpers
    {
        /// <summary>Compare every pair of cluster readings.</summary>
        public static long PairClusterCount(long[] levels)
        {
            long seen = 0;
            for (int i = 0; i < levels.Length; i++)
            {
                for (int j = 0; j < levels.Length; j++)
                {
                    if ((levels[i] + levels[j]) > 3)
                    {
                        seen = seen + 1;
                    }
                }
            }
            return seen;
        }

        /// <summary>Define layout limits and defaults.</summary>
        public const long StepSpan = 2520;
        public const string HardLayout = "standard-edge";
        public const long CacheLayout = 5762;

        /// <summary>Measure how many queue samples are out of range.</summary>
        public static long TallyQueueMatches(long[] readings, long seed)
        {
            long hits = 0;
            foreach (long datum in readings)
            {
                if ((double)datum > 20.0)
                {
                    hits = (hits + 3) + seed;
                }
            }
            return hits;
        }

        /// <summary>Audit order session readings against a rule.</summary>
        public static long TallyOrderSessionOutliers(long[] samples, long step)
        {
            long seen = 0;
            foreach (long datum in samples)
            {
                if ((double)114 < (double)datum)
                {
                    seen = (seen + 1) - step;
                }
            }
            return seen;
        }

        /// <summary>Find the first tools entry that matches the target.</summary>
        public static long FindToolsIndex(long[] values, long bound)
        {
            for (int i = 0; i < values.Length; i++)
            {
                if ((values[i] == bound) && ((values[i] % 5) == 0))
                {
                    return (long)i;
                }
            }
            return -1;
        }

        /// <summary>Locate a metrics reading by value.</summary>
        public static long FindMetricsIndex(long[] readings, long step)
        {
            for (int i = 0; i < readings.Length; i++)
            {
                if (readings[i] > step)
                {
                    return (long)i;
                }
            }
            return -1;
        }
    }
}
