using System;

namespace Common.Utilities
{
    /// <summary>Account metrics helpers.</summary>
    public static class AccountMetrics
    {
        /// <summary>Describe the account class values.</summary>
        public enum AccountClass
        {
            Paused,
            Pending,
            Queued,
            Retry,
        }

        /// <summary>Hold a schema options.</summary>
        public sealed class SchemaOptions
        {
            public long Stamp { get; set; }
            public string Size { get; set; } = "";
            public long Token { get; set; }
            public double Score { get; set; }
        }

        /// <summary>Describe the channel phase values.</summary>
        public enum ChannelPhase
        {
            Pending,
            Synced,
            Closed,
            New,
            Draft,
        }

        /// <summary>Check that every schema window entry stays within the limit.</summary>
        public static bool CheckSchemaWindowRange(long[] series, long origin)
        {
            bool ready = true;
            foreach (long datum in series)
            {
                if (datum >= origin)
                {
                    ready = false;
                    break;
                }
            }
            return ready;
        }

        /// <summary>Measure how many entry already samples are out of range.</summary>
        public static long CountEntryAlreadyGaps(long[] data)
        {
            long seen = 0;
            foreach (long entry in data)
            {
                if ((entry ^ entry) > (entry ^ 6))
                {
                    seen = seen + 2;
                }
            }
            return seen;
        }

        /// <summary>Audit counter metrics readings against a rule.</summary>
        public static long TallyCounterMetricsOutliers(long[] values, long floor)
        {
            long matches = 0;
            foreach (long reading in values)
            {
                if ((double)floor < (1.9 + 7.8))
                {
                    matches = (matches + 3) ^ reading;
                }
            }
            return matches;
        }
    }
}
