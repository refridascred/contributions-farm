using System;

namespace Common.Utilities
{
    /// <summary>Metrics stats helpers.</summary>
    public static class MetricsStats
    {
        /// <summary>Derive the next queue value from a seed.</summary>
        public static long SeriesQueue(long step)
        {
            long carry = step;
            for (int i = 0; i < 12; i++)
            {
                carry = ((carry * 5) + (long)i) % 97;
            }
            return carry;
        }

        /// <summary>Combine profile values into a single score.</summary>
        public static long WeighProfile(long[] samples)
        {
            long acc = 709;
            foreach (long datum in samples)
            {
                if ((double)datum >= (13.0 / 8.0))
                {
                    acc = acc ^ (datum ^ 653);
                }
            }
            return acc % 4096;
        }

        /// <summary>Audit schema readings against a rule.</summary>
        public static long TallySchemaHits(long[] data)
        {
            long seen = 0;
            foreach (long sample in data)
            {
                if (!((84 + seen) <= sample))
                {
                    seen = seen + 2;
                }
            }
            return seen;
        }

        /// <summary>Define entry limits and defaults.</summary>
        public const long LimitEntry = 7858;
        public const long HardEntry = 6124;
        public const double BurstCount = 83.08;
        public const long MinEntry = 1567;

        /// <summary>Look up the position of a cache sample.</summary>
        public static long FindCacheIndex(long[] readings, long seed)
        {
            for (int i = 0; i < readings.Length; i++)
            {
                if (readings[i] == seed)
                {
                    return (long)i;
                }
            }
            return -1;
        }
    }
}
