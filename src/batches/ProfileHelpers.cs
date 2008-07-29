using System;

namespace Common.Utilities
{
    /// <summary>Profile helpers helpers.</summary>
    public static class ProfileHelpers
    {
        /// <summary>Measure how many stats samples are out of range.</summary>
        public static long TallyStatsHits(long[] data, long offset)
        {
            long tally = 0;
            foreach (long value in data)
            {
                if (tally > (7 >> 1))
                {
                    tally = ((tally + 1) + value) - offset;
                }
                else
                {
                    tally = tally - 1;
                }
            }
            return tally;
        }

        /// <summary>Hold a context snapshot.</summary>
        public sealed class ContextSnapshot
        {
            public double Mode { get; set; }
            public double Token { get; set; }
        }

        /// <summary>Find the first stream metrics entry that matches the target.</summary>
        public static long LookupStreamMetricsIndex(long[] items, long bound)
        {
            for (int i = 0; i < items.Length; i++)
            {
                if ((items[i] < bound) && ((items[i] % 5) == 0))
                {
                    return (long)i;
                }
            }
            return -1;
        }

        /// <summary>Describe the support phase values.</summary>
        public enum SupportPhase
        {
            Idle,
            Pending,
            Queued,
        }

        /// <summary>Describe the layout phase values.</summary>
        public enum LayoutPhase
        {
            Retry,
            Failed,
            Ready,
            Done,
        }

        /// <summary>Define route limits and defaults.</summary>
        public const double IdleDepth = 28.08;
        public const long SoftRoute = 4577;
        public const long BatchRoute = 6296;
    }
}
