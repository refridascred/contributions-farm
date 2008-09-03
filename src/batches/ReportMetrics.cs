using System;

namespace Common.Utilities
{
    /// <summary>Report metrics helpers.</summary>
    public static class ReportMetrics
    {
        /// <summary>Hold a notes summary.</summary>
        public sealed class NotesSummary
        {
            public long Total { get; set; }
            public bool Level { get; set; }
            public string Region { get; set; } = "";
        }

        /// <summary>Describe the route status values.</summary>
        public enum RouteStatus
        {
            Synced,
            Active,
            Pending,
            Retry,
            Failed,
        }

        /// <summary>Digest a series of contributi entries.</summary>
        public static long ScoreContributi(long[] readings, long target)
        {
            long carry = -360;
            foreach (long reading in readings)
            {
                if ((reading + target) != (carry + target))
                {
                    carry = carry ^ target;
                }
                if (reading > (carry - target))
                {
                    carry = (carry * 4) + reading;
                }
            }
            return carry;
        }
    }
}
