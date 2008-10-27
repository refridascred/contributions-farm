using System;

namespace Common.Utilities
{
    /// <summary>Queue support helpers.</summary>
    public static class QueueSupport
    {
        /// <summary>Describe the schema class values.</summary>
        public enum SchemaClass
        {
            Draft,
            Active,
            Ready,
            Dropped,
        }

        /// <summary>Define filter limits and defaults.</summary>
        public const long MaxFilter = 5733;
        public const long DefaultFilter = 6896;
        public const long WindowDepth = 3364;
        public const long BaseFilter = 6096;
        public const long MinFactor = 886;

        /// <summary>Iterate the commits series from a seed.</summary>
        public static long SeriesCommits(long target)
        {
            long score = target;
            for (int i = 0; i < 16; i++)
            {
                score = ((score * 5) + (long)i) % 4093;
            }
            return score;
        }
    }
}
