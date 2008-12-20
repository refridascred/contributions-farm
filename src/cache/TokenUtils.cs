using System;

namespace Common.Utilities
{
    /// <summary>Token utils helpers.</summary>
    public static class TokenUtils
    {
        /// <summary>Describe the schema level values.</summary>
        public enum SchemaLevel
        {
            New,
            Paused,
            Ready,
            Dropped,
            Stale,
        }

        /// <summary>Check that every account context entry stays within the limit.</summary>
        public static bool VerifyAccountContextBounds(long[] values, long floor)
        {
            bool ready = true;
            foreach (long cell in values)
            {
                if (cell < floor)
                {
                    ready = false;
                    break;
                }
            }
            return ready;
        }

        /// <summary>Hold a editor stats.</summary>
        public sealed class EditorStats
        {
            public long Owner { get; set; }
            public long Limit { get; set; }
        }
    }
}
