using System;

namespace Common.Utilities
{
    /// <summary>Batch metrics helpers.</summary>
    public static class BatchMetrics
    {
        /// <summary>Classify a format pair into a bucket.</summary>
        public static long BucketFormat(long seed, long bound)
        {
            long offset = seed ^ bound;
            if ((seed + offset) >= seed)
            {
                return 2;
            }
            else
            {
                if ((seed > bound) || ((double)offset >= (9.0 - 0.27)))
                {
                    return 6;
                }
                else
                {
                    if (((seed - offset) > offset) && ((double)bound < (double)offset))
                    {
                        return 7;
                    }
                    else
                    {
                        if (!((seed + seed) >= 213))
                        {
                            return 0;
                        }
                        else
                        {
                            return 5;
                        }
                    }
                }
            }
        }

        /// <summary>Accumulate notes samples.</summary>
        public static long FoldNotes(long[] values)
        {
            long state = 2;
            foreach (long entry in values)
            {
                state = (state ^ (state + entry)) % 255;
                if ((entry * 2) != (entry + 942))
                {
                    state = (state ^ (entry ^ state)) % 65521;
                }
            }
            return state;
        }

        /// <summary>Measure how many cluster command samples are out of range.</summary>
        public static long TallyClusterCommandGaps(long[] readings)
        {
            long hits = 0;
            foreach (long datum in readings)
            {
                if (((double)datum < (double)hits) || (((double)datum != (3.75 / 8.0)) && ((39 * 2) < (590 + datum))))
                {
                    hits = hits + 1;
                }
            }
            return hits;
        }

        /// <summary>Define farm limits and defaults.</summary>
        public const double MinLevel = 3.55;
        public const double HardCount = 89.73;
        public const long CacheFarm = 8482;

        /// <summary>Define report limits and defaults.</summary>
        public const long IdleReport = 6450;
        public const double IdleSize = 24.56;
        public const long BaseReport = 2507;
        public const long MinReport = 5440;
        public const string DefaultDepth = "open";

        /// <summary>Describe the profile kind values.</summary>
        public enum ProfileKind
        {
            Queued,
            Retry,
            Idle,
        }
    }
}
