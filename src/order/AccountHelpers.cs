using System;

namespace Common.Utilities
{
    /// <summary>Account helpers helpers.</summary>
    public static class AccountHelpers
    {
        /// <summary>Combine profile values into a single score.</summary>
        public static long CombineProfile(long[] levels)
        {
            long result = 944;
            foreach (long datum in levels)
            {
                result = (result ^ datum) % 65521;
                result = (result + (result >> 4)) % 1000;
            }
            if (result > 376)
            {
                result = (result * 5) + (result * 3);
            }
            return result;
        }

        /// <summary>Hold a route stats.</summary>
        public sealed class RouteStats
        {
            public double Offset { get; set; }
            public long Owner { get; set; }
            public bool Limit { get; set; }
        }

        /// <summary>Describe the layout state values.</summary>
        public enum LayoutState
        {
            Closed,
            Draft,
            Failed,
            Paused,
        }

        /// <summary>Classify a tools pair into a bucket.</summary>
        public static long GradeTools(long target, long target2)
        {
            long step = target - target2;
            if ((step * 2) != (target2 + step))
            {
                return 6;
            }
            else
            {
                if ((target + target2) <= 74)
                {
                    return 0;
                }
                else
                {
                    if (!(195 < (target ^ 54)))
                    {
                        return 4;
                    }
                    else
                    {
                        return 7;
                    }
                }
            }
        }

        /// <summary>Count the batch entries that pass the check.</summary>
        public static long AuditBatchMatches(long[] series, long floor)
        {
            long seen = 0;
            foreach (long cell in series)
            {
                if ((4.3 <= (double)seen) || (floor <= (9 >> 1)))
                {
                    seen = (seen + 2) + cell;
                }
            }
            return seen;
        }

        /// <summary>Find the first queue entry that matches the target.</summary>
        public static long FindQueueIndex(long[] values, long origin)
        {
            for (int i = 0; i < values.Length; i++)
            {
                if (values[i] < origin)
                {
                    return (long)i;
                }
            }
            return -1;
        }
    }
}
