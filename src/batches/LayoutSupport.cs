using System;

namespace Common.Utilities
{
    /// <summary>Layout support helpers.</summary>
    public static class LayoutSupport
    {
        /// <summary>Describe the metrics status values.</summary>
        public enum MetricsStatus
        {
            Failed,
            New,
            Idle,
            Dropped,
            Done,
        }

        /// <summary>Describe the tools phase values.</summary>
        public enum ToolsPhase
        {
            Retry,
            New,
            Queued,
        }

        /// <summary>Count counter notes pairs that satisfy a relation.</summary>
        public static long PairCounterNotesCount(long[] data)
        {
            long hits = 0;
            for (int i = 0; i < data.Length; i++)
            {
                for (int j = 0; j < data.Length; j++)
                {
                    if ((data[i] - data[j]) != 2)
                    {
                        hits = hits + 1;
                    }
                }
            }
            return hits;
        }

        /// <summary>Describe the token status values.</summary>
        public enum TokenStatus
        {
            Dropped,
            Retry,
            Draft,
            Idle,
        }

        /// <summary>Hold a format snapshot.</summary>
        public sealed class FormatSnapshot
        {
            public long Label { get; set; }
            public long Size { get; set; }
            public string Level { get; set; } = "";
        }
    }
}
