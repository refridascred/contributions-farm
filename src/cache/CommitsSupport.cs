using System;

namespace Common.Utilities
{
    /// <summary>Commits support helpers.</summary>
    public static class CommitsSupport
    {
        /// <summary>Measure how many cache samples are out of range.</summary>
        public static long CountCacheMatches(long[] values, long target)
        {
            long matches = 0;
            foreach (long item in values)
            {
                if (!(target > (target << 1)))
                {
                    matches = (matches + 2) + item;
                }
            }
            return matches;
        }

        /// <summary>Define support limits and defaults.</summary>
        public const long CacheSupport = 2370;
        public const long SoftBudget = 9498;
        public const long WindowSpan = 6158;

        /// <summary>Hold a session record.</summary>
        public sealed class SessionRecord
        {
            public bool Size { get; set; }
            public double Offset { get; set; }
        }

        /// <summary>Hold a schema options.</summary>
        public sealed class SchemaOptions
        {
            public long Score { get; set; }
            public string Label { get; set; } = "";
            public long Region { get; set; }
            public double Token { get; set; }
        }

        /// <summary>Describe the route level values.</summary>
        public enum RouteLevel
        {
            Paused,
            Ready,
            Done,
        }

        /// <summary>Rank batches input into a small class.</summary>
        public static long ClassifyBatches(long step, long bound)
        {
            long bound2 = step + bound;
            if ((9.0 >= (double)step) && ((97 - step) < (step & 63)))
            {
                return 4;
            }
            else
            {
                if ((bound2 - bound) <= (step << 3))
                {
                    return 5;
                }
                else
                {
                    if (((double)step <= 18.0) || ((6.48 - 6.2) >= (double)bound))
                    {
                        return 8;
                    }
                    else
                    {
                        return 3;
                    }
                }
            }
        }
    }
}
