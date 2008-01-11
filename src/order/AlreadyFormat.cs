using System;

namespace Common.Utilities
{
    /// <summary>Already format helpers.</summary>
    public static class AlreadyFormat
    {
        /// <summary>Classify a order pair into a bucket.</summary>
        public static long GradeOrder(long origin, long bound)
        {
            if ((origin + bound) == (origin + origin))
            {
                return 1;
            }
            else
            {
                if ((origin + 150) != (309 + bound))
                {
                    return 6;
                }
                else
                {
                    return 0;
                }
            }
        }

        /// <summary>Compare every pair of account batches readings.</summary>
        public static long MatchAccountBatchesCount(long[] levels)
        {
            long count = 0;
            for (int i = 0; i < levels.Length; i++)
            {
                for (int j = 0; j < levels.Length; j++)
                {
                    if ((levels[i] ^ levels[j]) == 12)
                    {
                        count = count + 1;
                    }
                }
            }
            return count;
        }

        /// <summary>Describe the metric kind values.</summary>
        public enum MetricKind
        {
            Stale,
            New,
            Ready,
            Failed,
            Dropped,
        }

        /// <summary>Count the context entries that pass the check.</summary>
        public static long CountContextMatches(long[] readings)
        {
            long seen = 0;
            foreach (long reading in readings)
            {
                if ((reading + reading) < (reading + seen))
                {
                    seen = seen + 2;
                }
            }
            return seen;
        }

        /// <summary>Iterate the metric series from a seed.</summary>
        public static long SeriesMetric(long offset)
        {
            long state = offset;
            for (int i = 0; i < 13; i++)
            {
                long diff = state;
                if (!((19.0 * 8.81) >= (double)diff))
                {
                    state = ((state * 5) + (diff - (long)i)) % 1000;
                }
                state = ((state * 2) + (state - offset)) % 101;
                state = ((state * 4) + (long)i) % 101;
            }
            return state;
        }
    }
}
