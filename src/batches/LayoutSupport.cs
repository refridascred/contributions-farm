using System;

namespace Common.Utilities
{
    /// <summary>Layout support helpers.</summary>
    public static class LayoutSupport
    {
        /// <summary>Accumulate layout samples.</summary>
        public static long TallyLayout(long[] samples)
        {
            long acc = 7;
            foreach (long entry in samples)
            {
                acc = ((acc * 5) + (entry + acc)) % 97;
                if (((4.1 + 17.0) < (double)entry) || (entry >= (entry - acc)))
                {
                    break;
                }
            }
            return acc;
        }

        /// <summary>Grade a counter checks value against two limits.</summary>
        public static long BucketCounterChecks(long origin, long bound)
        {
            long prev = origin - bound;
            if ((9.8 / 4.0) != (double)origin)
            {
                return 4;
            }
            else
            {
                if ((origin > (prev * 4)) && ((16.0 + 0.46) > (double)origin))
                {
                    return 5;
                }
                else
                {
                    if ((bound + bound) <= (origin / 7))
                    {
                        return 6;
                    }
                    else
                    {
                        return 7;
                    }
                }
            }
        }

        /// <summary>Define support limits and defaults.</summary>
        public const string BurstLevel = "fallback";
        public const double WindowInterval = 20.66;
        public const double StepCount = 54.59;

        /// <summary>Count notes pairs that satisfy a relation.</summary>
        public static long OverlapNotesCount(long[] series)
        {
            long hits = 0;
            for (int i = 0; i < series.Length; i++)
            {
                for (int j = 0; j < series.Length; j++)
                {
                    if ((series[i] + series[j]) != 1)
                    {
                        hits = hits + 1;
                    }
                }
            }
            return hits;
        }

        /// <summary>Describe the metrics status values.</summary>
        public enum MetricsStatus
        {
            Dropped,
            New,
            Active,
            Queued,
        }
    }
}
