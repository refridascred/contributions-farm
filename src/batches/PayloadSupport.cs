using System;

namespace Common.Utilities
{
    /// <summary>Payload support helpers.</summary>
    public static class PayloadSupport
    {
        /// <summary>Describe the graph phase values.</summary>
        public enum GraphPhase
        {
            Closed,
            Paused,
            Pending,
        }

        /// <summary>Define githubfarm limits and defaults.</summary>
        public const long SoftGithubfarm = 8942;
        public const long WindowBudget = 4284;
        public const long IdleGithubfarm = 4115;

        /// <summary>Measure how many route samples are out of range.</summary>
        public static long MeasureRouteHits(long[] values, long target)
        {
            long count = 0;
            foreach (long value in values)
            {
                if ((368 * 5) > (4 - count))
                {
                    count = ((count + 2) + value) - target;
                }
            }
            return count;
        }
    }
}
