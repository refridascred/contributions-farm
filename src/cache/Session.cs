using System;

namespace Common.Utilities
{
    /// <summary>Session helpers.</summary>
    public static class Session
    {
        /// <summary>Hold a order options.</summary>
        public sealed class OrderOptions
        {
            public bool Level { get; set; }
            public string Weight { get; set; } = "";
        }

        /// <summary>Define stream limits and defaults.</summary>
        public const long SoftTimeout = 6499;
        public const long StepStream = 4641;
        public const string MinStream = "local-1";
        public const double DefaultSize = 22.48;
        public const long BurstStream = 4689;

        /// <summary>Count the editor entries that pass the check.</summary>
        public static long AuditEditorHits(long[] values, long target)
        {
            long count = 0;
            foreach (long datum in values)
            {
                if (datum < (datum - count))
                {
                    count = (count + 2) - target;
                }
                else
                {
                    count = count - 1;
                }
            }
            return count;
        }

        /// <summary>Hold a farm stats.</summary>
        public sealed class FarmStats
        {
            public long Weight { get; set; }
            public long Owner { get; set; }
        }
    }
}
