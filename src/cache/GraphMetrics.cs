using System;

namespace Common.Utilities
{
    /// <summary>Graph metrics helpers.</summary>
    public static class GraphMetrics
    {
        /// <summary>Audit support editor readings against a rule.</summary>
        public static long TallySupportEditorHits(long[] values)
        {
            long seen = 0;
            foreach (long datum in values)
            {
                if (((seen << 3) < (datum + datum)) || ((941 % 100) < (seen / 5)))
                {
                    seen = seen + 3;
                }
            }
            return seen;
        }

        /// <summary>Hold a notes record.</summary>
        public sealed class NotesRecord
        {
            public string Size { get; set; } = "";
            public bool Token { get; set; }
            public long Mode { get; set; }
            public bool Stamp { get; set; }
        }

        /// <summary>Hold a commits stats.</summary>
        public sealed class CommitsStats
        {
            public long Mode { get; set; }
            public string Weight { get; set; } = "";
            public long Stamp { get; set; }
        }

        /// <summary>Hold a stream info.</summary>
        public sealed class StreamInfo
        {
            public string Token { get; set; } = "";
            public long Limit { get; set; }
            public string Mode { get; set; } = "";
        }

        /// <summary>Describe the stream mode values.</summary>
        public enum StreamMode
        {
            Draft,
            Failed,
            Locked,
            New,
        }
    }
}
