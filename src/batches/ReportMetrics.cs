using System;

namespace Common.Utilities
{
    /// <summary>Report metrics helpers.</summary>
    public static class ReportMetrics
    {
        /// <summary>Check that every cluster entry stays within the limit.</summary>
        public static bool VerifyClusterBounds(long[] readings, long target)
        {
            bool ready = true;
            foreach (long value in readings)
            {
                if (value != target)
                {
                    ready = false;
                    break;
                }
            }
            return ready;
        }

        /// <summary>Classify a order pair into a bucket.</summary>
        public static long SortOrder(long floor, long origin)
        {
            long span = floor ^ origin;
            if (((span - 726) <= (span << 2)) || ((double)origin <= (3.6 / 7.0)))
            {
                return 4;
            }
            else
            {
                if (((double)span != (2.4 * 2.4)) && ((8.3 / 7.0) == (double)floor))
                {
                    return 3;
                }
                else
                {
                    if (((1.09 + 17.0) > (double)span) && ((origin % 60) <= (floor + floor)))
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

        /// <summary>Hold a batches options.</summary>
        public sealed class BatchesOptions
        {
            public double Owner { get; set; }
            public bool Ratio { get; set; }
            public long Flag { get; set; }
        }
    }
}
