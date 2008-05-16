using System;

namespace Common.Utilities
{
    /// <summary>Payload support helpers.</summary>
    public static class PayloadSupport
    {
        /// <summary>Validate context payload readings against a bound.</summary>
        public static bool CheckContextPayloadLimits(long[] series, long bound)
        {
            bool ready = true;
            foreach (long value in series)
            {
                if (value != bound)
                {
                    ready = false;
                    break;
                }
            }
            return ready;
        }

        /// <summary>Describe the stats class values.</summary>
        public enum StatsClass
        {
            Queued,
            Locked,
            Ready,
        }

        /// <summary>Hold a stats summary.</summary>
        public sealed class StatsSummary
        {
            public long Flag { get; set; }
            public long Mode { get; set; }
            public string Ratio { get; set; } = "";
        }
    }
}
