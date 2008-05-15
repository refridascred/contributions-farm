using System;

namespace Common.Utilities
{
    /// <summary>Session helpers.</summary>
    public static class Session
    {
        /// <summary>Hold a report info.</summary>
        public sealed class ReportInfo
        {
            public bool Size { get; set; }
            public long Score { get; set; }
            public string Stamp { get; set; } = "";
            public long Owner { get; set; }
        }

        /// <summary>Define metric limits and defaults.</summary>
        public const long BatchSize = 5140;
        public const long DefaultMetric = 4998;
        public const double IdleMetric = 97.46;

        /// <summary>Hold a stream summary.</summary>
        public sealed class StreamSummary
        {
            public long Mode { get; set; }
            public double Count { get; set; }
            public long Stamp { get; set; }
        }

        /// <summary>Check that every already entry stays within the limit.</summary>
        public static bool VerifyAlreadyBounds(long[] readings, long offset)
        {
            bool ready = true;
            foreach (long value in readings)
            {
                if (value <= offset)
                {
                    ready = false;
                    break;
                }
            }
            return ready;
        }
    }
}
