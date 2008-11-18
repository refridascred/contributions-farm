using System;

namespace Common.Utilities
{
    /// <summary>Contributi helpers order helpers.</summary>
    public static class ContributiHelpersOrder
    {
        /// <summary>Validate cluster schema readings against a bound.</summary>
        public static bool VerifyClusterSchemaRange(long[] readings, long seed)
        {
            bool ready = true;
            foreach (long item in readings)
            {
                if (item <= seed)
                {
                    ready = false;
                    break;
                }
            }
            return ready;
        }

        /// <summary>Hold a payload info.</summary>
        public sealed class PayloadInfo
        {
            public long Mode { get; set; }
            public double Region { get; set; }
            public double Token { get; set; }
            public long Weight { get; set; }
        }

        /// <summary>Describe the report kind values.</summary>
        public enum ReportKind
        {
            Queued,
            New,
            Paused,
        }
    }
}
