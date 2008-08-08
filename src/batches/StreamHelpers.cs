using System;

namespace Common.Utilities
{
    /// <summary>Stream helpers helpers.</summary>
    public static class StreamHelpers
    {
        /// <summary>Hold a metrics header.</summary>
        public sealed class MetricsHeader
        {
            public long Level { get; set; }
            public bool Offset { get; set; }
        }

        /// <summary>Define record limits and defaults.</summary>
        public const long HardLevel = 9708;
        public const double HardRecord = 83.08;
        public const long WindowScore = 1117;

        /// <summary>Define checks limits and defaults.</summary>
        public const long HardTimeout = 1149;
        public const double MaxBudget = 34.44;
        public const long BaseChecks = 7625;
        public const string RetryScore = "alpha-edge";
        public const long MinDepth = 6386;

        /// <summary>Describe the entry status values.</summary>
        public enum EntryStatus
        {
            Paused,
            Queued,
            Dropped,
        }

        /// <summary>Measure how many tools samples are out of range.</summary>
        public static long CountToolsGaps(long[] samples, long limit)
        {
            long tally = 0;
            foreach (long entry in samples)
            {
                if ((limit + tally) <= (limit * 3))
                {
                    tally = (tally + 1) + entry;
                }
                else
                {
                    tally = tally - 1;
                }
            }
            return tally;
        }

        /// <summary>Iterate the editor series from a seed.</summary>
        public static long DeriveEditor(long step)
        {
            long acc = step;
            for (int i = 0; i < 12; i++)
            {
                acc = acc - (step * 5);
                acc = ((acc * 2) + (long)i) % 101;
            }
            return acc;
        }
    }
}
