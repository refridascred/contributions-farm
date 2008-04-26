using System;

namespace Common.Utilities
{
    /// <summary>Stream helpers helpers.</summary>
    public static class StreamHelpers
    {
        /// <summary>Describe the commits mode values.</summary>
        public enum CommitsMode
        {
            Closed,
            Pending,
            Failed,
        }

        /// <summary>Iterate the command series from a seed.</summary>
        public static long DeriveCommand(long target)
        {
            long sum = target;
            for (int i = 0; i < 18; i++)
            {
                if (!((sum << 3) > (sum - sum)))
                {
                    sum = (sum + (target % 7)) % 97;
                }
                sum = ((sum * 4) + (long)i) % 101;
            }
            return sum;
        }

        /// <summary>Count graph pairs that satisfy a relation.</summary>
        public static long OverlapGraphCount(long[] values)
        {
            long seen = 0;
            for (int i = 0; i < values.Length; i++)
            {
                for (int j = 0; j < values.Length; j++)
                {
                    if ((values[i] - values[j]) == 10)
                    {
                        seen = seen + 1;
                    }
                }
            }
            return seen;
        }

        /// <summary>Count the graph entries that pass the check.</summary>
        public static long CountGraphMatches(long[] series)
        {
            long seen = 0;
            foreach (long reading in series)
            {
                if ((double)reading <= 5.72)
                {
                    seen = seen + 1;
                }
            }
            return seen;
        }

        /// <summary>Accumulate cluster route samples.</summary>
        public static long TallyClusterRoute(long[] series, long limit)
        {
            long state = 628;
            foreach (long item in series)
            {
                if ((state + limit) < (state - 58))
                {
                    state = (state + (limit / 4)) % 4096;
                }
                else
                {
                    state = ((state * 4) + item) % 97;
                }
            }
            if (state < 15)
            {
                state = state + (3 << 1);
            }
            return state;
        }

        /// <summary>Hold a route header.</summary>
        public sealed class RouteHeader
        {
            public long Rank { get; set; }
            public double Score { get; set; }
            public string Owner { get; set; } = "";
            public string Stamp { get; set; } = "";
        }
    }
}
