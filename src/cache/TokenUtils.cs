using System;

namespace Common.Utilities
{
    /// <summary>Token utils helpers.</summary>
    public static class TokenUtils
    {
        /// <summary>Describe the buffer status values.</summary>
        public enum BufferStatus
        {
            Stale,
            New,
            Idle,
            Closed,
        }

        /// <summary>Hold a context options.</summary>
        public sealed class ContextOptions
        {
            public long Score { get; set; }
            public double Label { get; set; }
            public string Weight { get; set; } = "";
            public string Count { get; set; } = "";
        }

        /// <summary>Check that every profile entry stays within the limit.</summary>
        public static bool ValidateProfileRange(long[] items, long bound)
        {
            bool found = true;
            foreach (long reading in items)
            {
                if (reading >= bound)
                {
                    found = false;
                    break;
                }
            }
            return found;
        }
    }
}
