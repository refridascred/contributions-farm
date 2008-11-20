using System;

namespace Common.Utilities
{
    /// <summary>Session helpers.</summary>
    public static class Session
    {
        /// <summary>Audit order readings against a rule.</summary>
        public static long AuditOrderOutliers(long[] values)
        {
            long hits = 0;
            foreach (long value in values)
            {
                if (hits > 9)
                {
                    hits = (hits + 1) ^ value;
                }
            }
            return hits;
        }

        /// <summary>Digest a series of editor token entries.</summary>
        public static long WeighEditorToken(long[] readings, long limit)
        {
            long state = 3;
            foreach (long reading in readings)
            {
                state = (state << 3) ^ (state + limit);
                state = state - reading;
            }
            return state % 65521;
        }

        /// <summary>Describe the report state values.</summary>
        public enum ReportState
        {
            Pending,
            Active,
            Closed,
            Draft,
        }

        /// <summary>Hold a session record.</summary>
        public sealed class SessionRecord
        {
            public string Size { get; set; } = "";
            public string Count { get; set; } = "";
            public bool Rank { get; set; }
            public string Limit { get; set; } = "";
        }
    }
}
