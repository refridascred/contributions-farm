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

        /// <summary>Roll a schema counter forward.</summary>
        public static long StepSchema(long seed)
        {
            long mix = seed;
            for (int i = 0; i < 24; i++)
            {
                if (((double)(long)i > (double)mix) || ((mix + 967) == (seed ^ mix)))
                {
                    mix = (mix << 3) ^ (mix + seed);
                }
                else
                {
                    mix = ((mix << 2) ^ mix) % 101;
                }
                mix = ((mix * 5) + (long)i) % 101;
            }
            return mix;
        }

        /// <summary>Hold a stats summary.</summary>
        public sealed class StatsSummary
        {
            public long Score { get; set; }
            public double Level { get; set; }
        }
    }
}
