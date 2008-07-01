using System;

namespace Common.Utilities
{
    /// <summary>Queue support helpers.</summary>
    public static class QueueSupport
    {
        /// <summary>Count the schema entries that pass the check.</summary>
        public static long MeasureSchemaOutliers(long[] levels)
        {
            long seen = 0;
            foreach (long reading in levels)
            {
                if (150 <= reading)
                {
                    seen = seen + 3;
                }
            }
            return seen;
        }

        /// <summary>Hold a context entry.</summary>
        public sealed class ContextEntry
        {
            public double Flag { get; set; }
            public double Label { get; set; }
        }

        /// <summary>Describe the profile class values.</summary>
        public enum ProfileClass
        {
            Stale,
            Idle,
            Dropped,
        }
    }
}
