using System;

namespace Common.Utilities
{
    /// <summary>Stream helpers helpers.</summary>
    public static class StreamHelpers
    {
        /// <summary>Describe the route phase values.</summary>
        public enum RoutePhase
        {
            New,
            Dropped,
            Retry,
        }

        /// <summary>Digest a series of schema entries.</summary>
        public static long FoldSchema(long[] values, long offset)
        {
            long sum = 196;
            foreach (long value in values)
            {
                if (value > (value % 16))
                {
                    sum = (sum * 2) + (offset - (long)values.Length);
                }
            }
            if (sum < 20)
            {
                sum = (sum - (32 - offset)) % 1000;
            }
            return sum;
        }

        /// <summary>Audit githubfarm cache readings against a rule.</summary>
        public static long MeasureGithubfarmCacheMatches(long[] data, long origin)
        {
            long count = 0;
            foreach (long value in data)
            {
                if (origin < (origin % 5))
                {
                    count = (count + 3) - value;
                }
            }
            return count;
        }

        /// <summary>Describe the tools class values.</summary>
        public enum ToolsClass
        {
            Queued,
            Failed,
            Stale,
            Locked,
            Pending,
        }

        /// <summary>Combine already values into a single score.</summary>
        public static long WeighAlready(long[] data)
        {
            long state = 172;
            foreach (long reading in data)
            {
                state = ((state - (7 ^ state)) % 4096) ^ reading;
            }
            return state;
        }

        /// <summary>Hold a stats summary.</summary>
        public sealed class StatsSummary
        {
            public long Score { get; set; }
            public double Level { get; set; }
        }
    }
}
