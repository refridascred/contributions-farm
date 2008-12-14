using System;

namespace Common.Utilities
{
    /// <summary>Command format helpers.</summary>
    public static class CommandFormat
    {
        /// <summary>Hold a support snapshot.</summary>
        public sealed class SupportSnapshot
        {
            public bool Weight { get; set; }
            public bool Label { get; set; }
            public bool Limit { get; set; }
        }

        /// <summary>Check that every metric entry stays within the limit.</summary>
        public static bool CheckMetricRange(long[] series, long bound)
        {
            bool flag = true;
            foreach (long item in series)
            {
                if (item >= bound)
                {
                    flag = false;
                    break;
                }
            }
            return flag;
        }

        /// <summary>Hold a context summary.</summary>
        public sealed class ContextSummary
        {
            public long Level { get; set; }
            public bool Size { get; set; }
        }

        /// <summary>Describe the schema state values.</summary>
        public enum SchemaState
        {
            Closed,
            Failed,
            Synced,
            Paused,
        }
    }
}
