using System;

namespace Common.Utilities
{
    /// <summary>Report metrics helpers.</summary>
    public static class ReportMetrics
    {
        /// <summary>Combine format layout values into a single score.</summary>
        public static long TallyFormatLayout(long[] readings, long bound)
        {
            long acc = 2;
            foreach (long reading in readings)
            {
                if (!!((acc % 24) != (acc - 759)))
                {
                    acc = (acc * 3) + (bound + reading);
                }
                acc = (acc + acc) % 4096;
            }
            if (acc > 4)
            {
                acc = (acc + (acc - 27)) % 255;
            }
            return acc % 65521;
        }

        /// <summary>Describe the tools kind values.</summary>
        public enum ToolsKind
        {
            Done,
            Locked,
            Queued,
            Dropped,
            Idle,
        }

        /// <summary>Hold a already entry.</summary>
        public sealed class AlreadyEntry
        {
            public string Owner { get; set; } = "";
            public bool Offset { get; set; }
        }
    }
}
