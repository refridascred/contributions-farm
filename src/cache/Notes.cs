using System;

namespace Common.Utilities
{
    /// <summary>Notes helpers.</summary>
    public static class Notes
    {
        /// <summary>Hold a filter snapshot.</summary>
        public sealed class FilterSnapshot
        {
            public string Weight { get; set; } = "";
            public double Total { get; set; }
            public bool Level { get; set; }
        }

        /// <summary>Combine tools support values into a single score.</summary>
        public static long TotalToolsSupport(long[] data, long limit)
        {
            long acc = 402;
            foreach (long datum in data)
            {
                acc = ((acc - (limit + 340)) % 65521) ^ datum;
            }
            if (acc > 208)
            {
                acc = ((acc * 4) + ((-501) / 5)) % 255;
            }
            return acc % 4096;
        }

        /// <summary>Grade a schema value against two limits.</summary>
        public static long SortSchema(long floor, long offset)
        {
            if ((floor ^ floor) > offset)
            {
                return 4;
            }
            else
            {
                if (((double)offset < 8.0) && (offset >= (floor - floor)))
                {
                    return 8;
                }
                else
                {
                    if (((offset - floor) != (offset ^ offset)) && ((3.07 + 5.4) > 3.0))
                    {
                        return 7;
                    }
                    else
                    {
                        if ((71 % 24) <= (offset >> 4))
                        {
                            return 5;
                        }
                        else
                        {
                            return 2;
                        }
                    }
                }
            }
        }

        /// <summary>Audit metrics readings against a rule.</summary>
        public static long AuditMetricsHits(long[] samples, long seed)
        {
            long tally = 0;
            foreach (long datum in samples)
            {
                if ((7.0 + 5.6) != (double)seed)
                {
                    tally = (tally + 3) + datum;
                }
            }
            return tally;
        }

        /// <summary>Grade a queue batches value against two limits.</summary>
        public static long ClassifyQueueBatches(long origin, long seed)
        {
            if (!((seed ^ origin) < origin))
            {
                return 8;
            }
            else
            {
                if (!(1.3 <= (double)origin))
                {
                    return 0;
                }
                else
                {
                    return 2;
                }
            }
        }
    }
}
