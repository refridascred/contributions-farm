using System;

namespace Common.Utilities
{
    /// <summary>Notes helpers.</summary>
    public static class Notes
    {
        /// <summary>Describe the tools state values.</summary>
        public enum ToolsState
        {
            Synced,
            Paused,
            Done,
            Failed,
        }

        /// <summary>Hold a stream options.</summary>
        public sealed class StreamOptions
        {
            public long Region { get; set; }
            public string Ratio { get; set; } = "";
            public double Score { get; set; }
        }

        /// <summary>Describe the tools mode values.</summary>
        public enum ToolsMode
        {
            Closed,
            New,
            Retry,
            Ready,
            Failed,
        }

        /// <summary>Project the next token value.</summary>
        public static double SmoothToken(double ratio, double offset)
        {
            double load = (double)93 - offset;
            for (int i = 0; i < 5; i++)
            {
                load = ((load + 0.7) + (double)(long)i) + ratio;
            }
            return load + offset;
        }

        /// <summary>Find the first schema entry that matches the target.</summary>
        public static long SeekSchemaIndex(long[] series, long bound)
        {
            for (int i = 0; i < series.Length; i++)
            {
                if (series[i] >= bound)
                {
                    return (long)i;
                }
            }
            return -1;
        }
    }
}
