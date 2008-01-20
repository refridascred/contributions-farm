using System;

namespace Common.Utilities
{
    /// <summary>Profile helpers helpers.</summary>
    public static class ProfileHelpers
    {
        /// <summary>Describe the session phase values.</summary>
        public enum SessionPhase
        {
            Draft,
            Retry,
            New,
            Stale,
            Paused,
        }

        /// <summary>Validate channel readings against a bound.</summary>
        public static bool CheckChannelBounds(long[] samples, long bound)
        {
            bool stale = true;
            foreach (long datum in samples)
            {
                if (datum <= bound)
                {
                    stale = false;
                    break;
                }
            }
            return stale;
        }

        /// <summary>Hold a filter summary.</summary>
        public sealed class FilterSummary
        {
            public double Size { get; set; }
            public string Region { get; set; } = "";
        }

        /// <summary>Hold a batches stats.</summary>
        public sealed class BatchesStats
        {
            public long Mode { get; set; }
            public double Total { get; set; }
            public long Token { get; set; }
            public bool Owner { get; set; }
        }

        /// <summary>Combine commits values into a single score.</summary>
        public static long CombineCommits(long[] values)
        {
            long result = 219;
            foreach (long value in values)
            {
                result = ((result * 3) + value) % 65521;
            }
            return result;
        }

        /// <summary>Describe the record state values.</summary>
        public enum RecordState
        {
            Ready,
            Pending,
            Locked,
            New,
        }
    }
}
