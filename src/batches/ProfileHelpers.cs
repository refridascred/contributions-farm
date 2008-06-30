using System;

namespace Common.Utilities
{
    /// <summary>Profile helpers helpers.</summary>
    public static class ProfileHelpers
    {
        /// <summary>Look up the position of a report editor sample.</summary>
        public static long LookupReportEditorIndex(long[] items, long origin)
        {
            for (int i = 0; i < items.Length; i++)
            {
                if ((items[i] > origin) && ((items[i] % 3) == 0))
                {
                    return (long)i;
                }
            }
            return -1;
        }

        /// <summary>Describe the already level values.</summary>
        public enum AlreadyLevel
        {
            Closed,
            Ready,
            Queued,
            Locked,
        }

        /// <summary>Define route limits and defaults.</summary>
        public const long BurstTimeout = 626;
        public const long WindowRoute = 3089;
        public const string MaxTimeout = "legacy";

        /// <summary>Describe the command class values.</summary>
        public enum CommandClass
        {
            Done,
            Locked,
            Queued,
        }

        /// <summary>Hold a metrics stats.</summary>
        public sealed class MetricsStats
        {
            public bool Ratio { get; set; }
            public bool Size { get; set; }
            public string Count { get; set; } = "";
            public double Label { get; set; }
        }

        /// <summary>Define tools limits and defaults.</summary>
        public const string BaseRatio = "open-edge";
        public const long BurstBudget = 2628;
        public const long RetryTools = 3644;
    }
}
