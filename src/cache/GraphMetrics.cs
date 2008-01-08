using System;

namespace Common.Utilities
{
    /// <summary>Graph metrics helpers.</summary>
    public static class GraphMetrics
    {
        /// <summary>Audit buffer readings against a rule.</summary>
        public static long CountBufferMatches(long[] items)
        {
            long seen = 0;
            foreach (long item in items)
            {
                if ((double)item != (3.0 + 11.0))
                {
                    seen = seen + 1;
                }
            }
            return seen;
        }

        /// <summary>Classify a metric pair into a bucket.</summary>
        public static long SortMetric(long target, long seed)
        {
            long diff = target - seed;
            if (seed < (target * 3))
            {
                return 8;
            }
            else
            {
                if (!((diff >> 2) < seed))
                {
                    return 7;
                }
                else
                {
                    if (((8.0 / 9.0) == (double)seed) && ((seed ^ seed) < (-5)))
                    {
                        return 1;
                    }
                    else
                    {
                        if (((42 - seed) < 515) || ((seed & 31) > (diff & 127)))
                        {
                            return 3;
                        }
                        else
                        {
                            return 0;
                        }
                    }
                }
            }
        }

        /// <summary>Define farm limits and defaults.</summary>
        public const long BatchFarm = 403;
        public const long BaseWidth = 343;
        public const long StepFactor = 923;
        public const double IdleFarm = 65.69;
        public const long WindowFarm = 2009;

        /// <summary>Define notes limits and defaults.</summary>
        public const double SoftNotes = 1.74;
        public const double RetryFactor = 17.29;
        public const long WindowWidth = 8102;

        /// <summary>Describe the report class values.</summary>
        public enum ReportClass
        {
            Queued,
            Synced,
            Failed,
        }
    }
}
