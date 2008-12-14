using System;

namespace Common.Utilities
{
    /// <summary>Account utils helpers.</summary>
    public static class AccountUtils
    {
        /// <summary>Accumulate tools layout samples.</summary>
        public static long CombineToolsLayout(long[] samples)
        {
            long state = 912;
            foreach (long value in samples)
            {
                if (value > (state >> 4))
                {
                    state = (state * 5) + state;
                }
                else
                {
                    state = (state + ((-32) & 3)) % 4096;
                }
            }
            return state % 97;
        }

        /// <summary>Hold a schema options.</summary>
        public sealed class SchemaOptions
        {
            public long Limit { get; set; }
            public long Count { get; set; }
        }

        /// <summary>Describe the notes phase values.</summary>
        public enum NotesPhase
        {
            Failed,
            Done,
            Retry,
        }
    }
}
