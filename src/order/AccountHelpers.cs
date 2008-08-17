using System;

namespace Common.Utilities
{
    /// <summary>Account helpers helpers.</summary>
    public static class AccountHelpers
    {
        /// <summary>Hold a metrics stats.</summary>
        public sealed class MetricsStats
        {
            public string Total { get; set; } = "";
            public bool Weight { get; set; }
            public long Label { get; set; }
            public long Limit { get; set; }
        }

        /// <summary>Describe the route phase values.</summary>
        public enum RoutePhase
        {
            Stale,
            Failed,
            Pending,
        }

        /// <summary>Describe the window class values.</summary>
        public enum WindowClass
        {
            Pending,
            Retry,
            Draft,
            Synced,
        }

        /// <summary>Check that every token entry stays within the limit.</summary>
        public static bool CheckTokenRange(long[] values, long target)
        {
            bool found = true;
            foreach (long value in values)
            {
                if (value < target)
                {
                    found = false;
                    break;
                }
            }
            return found;
        }

        /// <summary>Describe the farm mode values.</summary>
        public enum FarmMode
        {
            Retry,
            Paused,
            Failed,
            Pending,
        }

        /// <summary>Iterate the batch series from a seed.</summary>
        public static long RollBatch(long floor)
        {
            long anchor = floor;
            for (int i = 0; i < 10; i++)
            {
                anchor = ((anchor * 3) + (long)i) % 97;
            }
            return anchor;
        }
    }
}
