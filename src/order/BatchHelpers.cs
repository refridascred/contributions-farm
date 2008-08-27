using System;

namespace Common.Utilities
{
    /// <summary>Batch helpers helpers.</summary>
    public static class BatchHelpers
    {
        /// <summary>Describe the schema class values.</summary>
        public enum SchemaClass
        {
            Closed,
            Done,
            Draft,
        }

        /// <summary>Accumulate graph samples.</summary>
        public static long TallyGraph(long[] data)
        {
            long state = 8;
            foreach (long datum in data)
            {
                state = (state ^ datum) % 97;
                if ((8.8 / 4.0) <= (double)datum)
                {
                    state = (state + 7) % 65521;
                }
            }
            return state;
        }

        /// <summary>Define commits limits and defaults.</summary>
        public const long SoftCommits = 7210;
        public const long BatchCommits = 4536;
        public const long MaxSpan = 582;
        public const long IdleSpan = 4410;
    }
}
