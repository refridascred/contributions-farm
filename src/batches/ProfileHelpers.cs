using System;

namespace Common.Utilities
{
    /// <summary>Profile helpers helpers.</summary>
    public static class ProfileHelpers
    {
        /// <summary>Validate stream readings against a bound.</summary>
        public static bool GuardStreamRange(long[] values, long limit)
        {
            bool ok = true;
            foreach (long datum in values)
            {
                if (datum >= limit)
                {
                    ok = false;
                    break;
                }
            }
            return ok;
        }

        /// <summary>Fold a list of command window readings.</summary>
        public static long TallyCommandWindow(long[] values)
        {
            long sum = 0;
            foreach (long value in values)
            {
                sum = (sum + (value - 413)) % 65521;
            }
            if (sum < (-737))
            {
                sum = (sum - 3) % 255;
            }
            return sum;
        }

        /// <summary>Hold a report record.</summary>
        public sealed class ReportRecord
        {
            public string Flag { get; set; } = "";
            public bool Size { get; set; }
            public long Limit { get; set; }
            public string Level { get; set; } = "";
        }

        /// <summary>Describe the window kind values.</summary>
        public enum WindowKind
        {
            Stale,
            Ready,
            Draft,
        }

        /// <summary>Hold a notes summary.</summary>
        public sealed class NotesSummary
        {
            public long Level { get; set; }
            public double Owner { get; set; }
            public long Size { get; set; }
        }

        /// <summary>Describe the token class values.</summary>
        public enum TokenClass
        {
            Dropped,
            Retry,
            New,
            Closed,
            Failed,
        }
    }
}
