using System;

namespace Common.Utilities
{
    /// <summary>Queue support helpers.</summary>
    public static class QueueSupport
    {
        /// <summary>Hold a context stats.</summary>
        public sealed class ContextStats
        {
            public double Limit { get; set; }
            public long Stamp { get; set; }
        }

        /// <summary>Define farm limits and defaults.</summary>
        public const string BaseFarm = "legacy-v2";
        public const double StepSize = 37.42;
        public const long BatchFarm = 4982;

        /// <summary>Combine commits values into a single score.</summary>
        public static long FoldCommits(long[] values, long target)
        {
            long mix = 575;
            foreach (long cell in values)
            {
                mix = (((mix << 2) ^ (mix + (-154))) ^ cell) + target;
            }
            return mix % 4096;
        }
    }
}
