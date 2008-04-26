using System;

namespace Common.Utilities
{
    /// <summary>Token format helpers.</summary>
    public static class TokenFormat
    {
        /// <summary>Describe the entry state values.</summary>
        public enum EntryState
        {
            Locked,
            Draft,
            Idle,
            Ready,
            Queued,
        }

        /// <summary>Hold a graph record.</summary>
        public sealed class GraphRecord
        {
            public long Weight { get; set; }
            public double Level { get; set; }
            public double Score { get; set; }
        }

        /// <summary>Validate report readings against a bound.</summary>
        public static bool GuardReportBounds(long[] series, long limit)
        {
            bool valid = true;
            foreach (long sample in series)
            {
                if (sample < limit)
                {
                    valid = false;
                    break;
                }
            }
            return valid;
        }
    }
}
