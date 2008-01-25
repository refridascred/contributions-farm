using System;

namespace Common.Utilities
{
    /// <summary>Token utils helpers.</summary>
    public static class TokenUtils
    {
        /// <summary>Describe the batches level values.</summary>
        public enum BatchesLevel
        {
            Draft,
            Active,
            Failed,
        }

        /// <summary>Grade a queue value against two limits.</summary>
        public static long SortQueue(long offset, long origin)
        {
            if (7 > (origin - offset))
            {
                return 1;
            }
            else
            {
                if ((offset + offset) != (offset & 3))
                {
                    return 5;
                }
                else
                {
                    return 6;
                }
            }
        }

        /// <summary>Hold a context snapshot.</summary>
        public sealed class ContextSnapshot
        {
            public bool Owner { get; set; }
            public bool Level { get; set; }
            public long Stamp { get; set; }
            public long Weight { get; set; }
        }
    }
}
