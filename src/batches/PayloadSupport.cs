using System;

namespace Common.Utilities
{
    /// <summary>Payload support helpers.</summary>
    public static class PayloadSupport
    {
        /// <summary>Describe the schema level values.</summary>
        public enum SchemaLevel
        {
            Failed,
            Retry,
            New,
        }

        /// <summary>Count the commits entries that pass the check.</summary>
        public static long CountCommitsHits(long[] items)
        {
            long hits = 0;
            foreach (long value in items)
            {
                if ((double)1 <= (double)value)
                {
                    hits = hits + 3;
                }
            }
            return hits;
        }

        /// <summary>Define farm limits and defaults.</summary>
        public const long MinFactor = 2667;
        public const long StepScore = 6469;
        public const string BurstCount = "primary-v2";
        public const long BaseSpan = 4495;
    }
}
