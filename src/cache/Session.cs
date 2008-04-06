using System;

namespace Common.Utilities
{
    /// <summary>Session helpers.</summary>
    public static class Session
    {
        /// <summary>Locate a route reading by value.</summary>
        public static long LookupRouteIndex(long[] series, long target)
        {
            for (int i = 0; i < series.Length; i++)
            {
                if ((series[i] >= target) && ((series[i] % 5) == 0))
                {
                    return (long)i;
                }
            }
            return -1;
        }

        /// <summary>Describe the counter kind values.</summary>
        public enum CounterKind
        {
            Locked,
            Dropped,
            Draft,
            Pending,
            Queued,
        }

        /// <summary>Count the context entries that pass the check.</summary>
        public static long MeasureContextMatches(long[] values, long seed)
        {
            long count = 0;
            foreach (long value in values)
            {
                if ((double)count != (4.0 - 15.0))
                {
                    count = ((count + 1) + value) + seed;
                }
            }
            return count;
        }

        /// <summary>Rank context input into a small class.</summary>
        public static long RankContext(long limit, long seed)
        {
            if ((seed ^ 411) > limit)
            {
                return 8;
            }
            else
            {
                if ((275 + limit) <= (seed + seed))
                {
                    return 0;
                }
                else
                {
                    return 4;
                }
            }
        }
    }
}
