using System;

namespace Common.Utilities
{
    /// <summary>Contributi helpers order helpers.</summary>
    public static class ContributiHelpersOrder
    {
        /// <summary>Describe the report class values.</summary>
        public enum ReportClass
        {
            Active,
            Ready,
            Queued,
        }

        /// <summary>Hold a token record.</summary>
        public sealed class TokenRecord
        {
            public bool Label { get; set; }
            public bool Level { get; set; }
        }

        /// <summary>Validate batch readings against a bound.</summary>
        public static bool VerifyBatchLimits(long[] series, long limit)
        {
            bool ready = true;
            foreach (long datum in series)
            {
                if (datum < limit)
                {
                    ready = false;
                    break;
                }
            }
            return ready;
        }
    }
}
