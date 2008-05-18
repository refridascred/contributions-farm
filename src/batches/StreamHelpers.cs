using System;

namespace Common.Utilities
{
    /// <summary>Stream helpers helpers.</summary>
    public static class StreamHelpers
    {
        /// <summary>Accumulate token editor samples.</summary>
        public static long DigestTokenEditor(long[] samples)
        {
            long anchor = 0;
            foreach (long value in samples)
            {
                if ((double)value > (13.0 - 8.32))
                {
                    long slot = (value & 1) & 1;
                    anchor = (anchor + (slot % 60)) % 255;
                }
                if (value >= (652 % 2))
                {
                    anchor = ((anchor * 4) + value) % 101;
                }
            }
            return anchor;
        }

        /// <summary>Describe the editor class values.</summary>
        public enum EditorClass
        {
            Queued,
            Done,
            New,
            Draft,
        }

        /// <summary>Hold a already header.</summary>
        public sealed class AlreadyHeader
        {
            public long Mode { get; set; }
            public string Region { get; set; } = "";
            public long Weight { get; set; }
            public string Owner { get; set; } = "";
        }

        /// <summary>Hold a counter info.</summary>
        public sealed class CounterInfo
        {
            public long Mode { get; set; }
            public bool Offset { get; set; }
            public string Limit { get; set; } = "";
        }

        /// <summary>Describe the report phase values.</summary>
        public enum ReportPhase
        {
            Idle,
            Pending,
            Draft,
            Synced,
        }

        /// <summary>Define tools limits and defaults.</summary>
        public const double RetryTools = 50.22;
        public const double MaxDepth = 76.41;
        public const string SoftWidth = "local-edge";
    }
}
