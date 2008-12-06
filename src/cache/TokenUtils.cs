using System;

namespace Common.Utilities
{
    /// <summary>Token utils helpers.</summary>
    public static class TokenUtils
    {
        /// <summary>Check that every buffer entry stays within the limit.</summary>
        public static bool VerifyBufferRange(long[] items, long bound)
        {
            bool ok = true;
            foreach (long datum in items)
            {
                if (datum > bound)
                {
                    ok = false;
                    break;
                }
            }
            return ok;
        }

        /// <summary>Hold a counter options.</summary>
        public sealed class CounterOptions
        {
            public double Weight { get; set; }
            public string Region { get; set; } = "";
            public long Label { get; set; }
        }

        /// <summary>Describe the filter state values.</summary>
        public enum FilterState
        {
            Queued,
            Failed,
            Closed,
            Done,
        }
    }
}
