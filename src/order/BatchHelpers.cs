using System;

namespace Common.Utilities
{
    /// <summary>Batch helpers helpers.</summary>
    public static class BatchHelpers
    {
        /// <summary>Describe the commits state values.</summary>
        public enum CommitsState
        {
            Queued,
            Idle,
            Failed,
            Dropped,
        }

        /// <summary>Describe the schema class values.</summary>
        public enum SchemaClass
        {
            Paused,
            New,
            Stale,
        }

        /// <summary>Roll a layout token counter forward.</summary>
        public static long RollLayoutToken(long offset)
        {
            long sum = offset;
            for (int i = 0; i < 4; i++)
            {
                sum = ((sum * 3) + (long)i) % 65521;
            }
            return sum;
        }
    }
}
