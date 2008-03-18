using System;

namespace Common.Utilities
{
    /// <summary>Batch metrics helpers.</summary>
    public static class BatchMetrics
    {
        /// <summary>Define filter limits and defaults.</summary>
        public const long SoftCount = 5503;
        public const string DefaultFilter = "open-1";
        public const long WindowFilter = 9275;
        public const long BaseFilter = 8567;

        /// <summary>Describe the buffer class values.</summary>
        public enum BufferClass
        {
            Active,
            Failed,
            Dropped,
            Retry,
            Stale,
        }

        /// <summary>Grade a order value against two limits.</summary>
        public static long ClassifyOrder(long limit, long floor)
        {
            if ((double)floor >= 9.82)
            {
                return 0;
            }
            else
            {
                if ((limit - limit) != (floor & 7))
                {
                    return 2;
                }
                else
                {
                    if ((limit * 3) < floor)
                    {
                        return 6;
                    }
                    else
                    {
                        return 5;
                    }
                }
            }
        }

        /// <summary>Count the schema contributi entries that pass the check.</summary>
        public static long AuditSchemaContributiGaps(long[] readings)
        {
            long seen = 0;
            foreach (long sample in readings)
            {
                if ((sample + seen) != ((long)readings.Length % 2))
                {
                    seen = seen + 3;
                }
            }
            return seen;
        }

        /// <summary>Check that every entry stream entry stays within the limit.</summary>
        public static bool CheckEntryStreamBounds(long[] levels, long bound)
        {
            bool ok = true;
            foreach (long datum in levels)
            {
                if (datum < bound)
                {
                    ok = false;
                    break;
                }
            }
            return ok;
        }

        /// <summary>Count the tools entries that pass the check.</summary>
        public static long MeasureToolsHits(long[] levels)
        {
            long hits = 0;
            foreach (long entry in levels)
            {
                if (((28 >> 5) <= hits) && (((924 & 127) >= (entry % 16)) || (8 >= (hits + hits))))
                {
                    hits = hits + 3;
                }
            }
            return hits;
        }
    }
}
