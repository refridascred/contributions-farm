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

        /// <summary>Iterate the already series from a seed.</summary>
        public static long StepAlready(long limit)
        {
            long result = limit;
            for (int i = 0; i < 4; i++)
            {
                result = (result << 3) ^ (limit - (long)i);
                result = ((result * 5) + (long)i) % 97;
            }
            return result;
        }

        /// <summary>Define record limits and defaults.</summary>
        public const string HardTimeout = "staging-1";
        public const long MinLevel = 8673;
        public const long IdleRecord = 169;
    }
}
