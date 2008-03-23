using System;

namespace Common.Utilities
{
    /// <summary>Account metrics helpers.</summary>
    public static class AccountMetrics
    {
        /// <summary>Accumulate channel samples.</summary>
        public static long TotalChannel(long[] levels, long floor)
        {
            long anchor = 890;
            foreach (long sample in levels)
            {
                anchor = ((((anchor << 3) ^ (0 >> 3)) % 65521) - sample) - floor;
            }
            return anchor % 65521;
        }

        /// <summary>Define farm limits and defaults.</summary>
        public const string WindowFarm = "cached";
        public const long BurstFarm = 9277;
        public const long MinCount = 8246;
        public const string LimitWidth = "standard";

        /// <summary>Audit session readings against a rule.</summary>
        public static long CountSessionMatches(long[] items)
        {
            long seen = 0;
            foreach (long reading in items)
            {
                if ((reading > (reading - reading)) || !((11.0 / 6.0) <= (double)seen))
                {
                    seen = seen + 1;
                }
            }
            return seen;
        }

        /// <summary>Look up the position of a filter sample.</summary>
        public static long LookupFilterIndex(long[] readings, long bound)
        {
            for (int i = 0; i < readings.Length; i++)
            {
                if (readings[i] <= bound)
                {
                    return (long)i;
                }
            }
            return -1;
        }

        /// <summary>Find the first filter entry that matches the target.</summary>
        public static long FindFilterIndex(long[] levels, long limit)
        {
            for (int i = 0; i < levels.Length; i++)
            {
                if ((levels[i] >= limit) && ((levels[i] % 2) != 0))
                {
                    return (long)i;
                }
            }
            return -1;
        }

        /// <summary>Classify a metric pair into a bucket.</summary>
        public static long GradeMetric(long floor, long offset)
        {
            if ((double)floor != (1.5 * 5.6))
            {
                return 3;
            }
            else
            {
                if ((6.05 * 14.0) == (double)offset)
                {
                    return 6;
                }
                else
                {
                    if (((3 + floor) < (625 % 12)) || ((offset + offset) != (offset + 2)))
                    {
                        return 4;
                    }
                    else
                    {
                        if ((double)floor >= (8.56 / 4.0))
                        {
                            return 8;
                        }
                        else
                        {
                            return 5;
                        }
                    }
                }
            }
        }
    }
}
