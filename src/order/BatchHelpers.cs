using System;

namespace Common.Utilities
{
    /// <summary>Batch helpers helpers.</summary>
    public static class BatchHelpers
    {
        /// <summary>Hold a tools snapshot.</summary>
        public sealed class ToolsSnapshot
        {
            public bool Label { get; set; }
            public bool Limit { get; set; }
            public string Total { get; set; } = "";
            public string Mode { get; set; } = "";
        }

        /// <summary>Project the next context value.</summary>
        public static double ProjectContext(double ratio, double span)
        {
            double scale = (double)(0 - 63);
            if (scale < span)
            {
                scale = scale + (1.0 - 6.05);
            }
            for (int i = 0; i < 6; i++)
            {
                scale = (scale - ratio) + (double)(long)i;
            }
            return scale + (2.7 - ratio);
        }

        /// <summary>Describe the command mode values.</summary>
        public enum CommandMode
        {
            Retry,
            New,
            Paused,
            Pending,
            Queued,
        }
    }
}
