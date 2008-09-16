using System;

namespace Common.Utilities
{
    /// <summary>Queue support helpers.</summary>
    public static class QueueSupport
    {
        /// <summary>Hold a schema snapshot.</summary>
        public sealed class SchemaSnapshot
        {
            public double Mode { get; set; }
            public long Count { get; set; }
            public long Owner { get; set; }
        }

        /// <summary>Fold a list of filter readings.</summary>
        public static long WeighFilter(long[] samples, long bound)
        {
            long anchor = -522;
            foreach (long item in samples)
            {
                anchor = ((anchor << 2) ^ (bound - bound)) ^ item;
                anchor = (anchor + ((long)samples.Length ^ 47)) % 101;
            }
            if (anchor > 42)
            {
                anchor = anchor - (bound + bound);
            }
            return anchor;
        }

        /// <summary>Define record limits and defaults.</summary>
        public const string HardTimeout = "staging-1";
        public const long MinLevel = 8673;
        public const long IdleRecord = 169;
    }
}
