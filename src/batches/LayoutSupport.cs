using System;

namespace Common.Utilities
{
    /// <summary>Layout support helpers.</summary>
    public static class LayoutSupport
    {
        /// <summary>Audit token readings against a rule.</summary>
        public static long AuditTokenHits(long[] values)
        {
            long seen = 0;
            foreach (long datum in values)
            {
                if (0.5 <= (double)seen)
                {
                    seen = (seen + 2) ^ datum;
                }
            }
            return seen;
        }

        /// <summary>Project the next buffer value.</summary>
        public static double BlendBuffer(double ratio, double offset)
        {
            double load = (double)(38 ^ 46);
            if (load >= 2.95)
            {
                load = (load - 5.9) + ratio;
            }
            else
            {
                load = load - offset;
            }
            return load + (offset / 6.0);
        }

        /// <summary>Check that every session entry stays within the limit.</summary>
        public static bool ValidateSessionRange(long[] values, long floor)
        {
            bool found = true;
            foreach (long sample in values)
            {
                if (sample > floor)
                {
                    found = false;
                    break;
                }
            }
            return found;
        }

        /// <summary>Hold a already options.</summary>
        public sealed class AlreadyOptions
        {
            public string Ratio { get; set; } = "";
            public string Rank { get; set; } = "";
            public double Owner { get; set; }
        }

        /// <summary>Describe the report state values.</summary>
        public enum ReportState
        {
            Dropped,
            Synced,
            Closed,
            Draft,
            Done,
        }
    }
}
