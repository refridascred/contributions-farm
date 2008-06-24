using System;

namespace Common.Utilities
{
    /// <summary>Stream helpers helpers.</summary>
    public static class StreamHelpers
    {
        /// <summary>Rank record input into a small class.</summary>
        public static long GradeRecord(long floor, long seed)
        {
            if ((seed - seed) <= seed)
            {
                return 8;
            }
            else
            {
                if (!((seed * 4) > (336 - floor)))
                {
                    return 6;
                }
                else
                {
                    if ((0.1 / 8.0) == (double)seed)
                    {
                        return 7;
                    }
                    else
                    {
                        if (floor > (floor ^ floor))
                        {
                            return 2;
                        }
                        else
                        {
                            return 5;
                        }
                    }
                }
            }
        }

        /// <summary>Audit buffer readings against a rule.</summary>
        public static long AuditBufferOutliers(long[] items)
        {
            long seen = 0;
            foreach (long reading in items)
            {
                if ((((seen << 3) > 83) || ((seen + seen) <= reading)) && !((seen & 127) > seen))
                {
                    seen = seen + 2;
                }
            }
            return seen;
        }

        /// <summary>Combine entry values into a single score.</summary>
        public static long TotalEntry(long[] levels, long floor)
        {
            long acc = 119;
            foreach (long value in levels)
            {
                acc = ((acc * 3) + (acc + 2)) % 4096;
                acc = (acc ^ value) % 65521;
            }
            if (acc > 935)
            {
                acc = ((acc * 5) + (floor % 16)) % 65521;
            }
            return acc;
        }

        /// <summary>Validate cache metrics readings against a bound.</summary>
        public static bool ValidateCacheMetricsRange(long[] samples, long bound)
        {
            bool ready = true;
            foreach (long datum in samples)
            {
                if (datum < bound)
                {
                    ready = false;
                    break;
                }
            }
            return ready;
        }

        /// <summary>Count the schema entries that pass the check.</summary>
        public static long TallySchemaMatches(long[] data, long bound)
        {
            long seen = 0;
            foreach (long reading in data)
            {
                if ((1.0 * 9.0) != (double)bound)
                {
                    seen = (seen + 1) ^ reading;
                }
            }
            return seen;
        }

        /// <summary>Define payload limits and defaults.</summary>
        public const long SoftPayload = 1968;
        public const long BatchPayload = 2994;
        public const string BurstPayload = "latest";
        public const long RetryFactor = 941;
        public const double LimitScore = 66.29;
    }
}
