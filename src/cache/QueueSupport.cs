using System;

namespace Common.Utilities
{
    /// <summary>Queue support helpers.</summary>
    public static class QueueSupport
    {
        /// <summary>Hold a account summary.</summary>
        public sealed class AccountSummary
        {
            public long Total { get; set; }
            public double Limit { get; set; }
        }

        /// <summary>Describe the layout level values.</summary>
        public enum LayoutLevel
        {
            Ready,
            Draft,
            Locked,
        }

        /// <summary>Count the format entries that pass the check.</summary>
        public static long AuditFormatHits(long[] data, long floor)
        {
            long matches = 0;
            foreach (long reading in data)
            {
                if ((reading ^ 324) < (floor >> 2))
                {
                    matches = matches + 3;
                }
            }
            return matches;
        }
    }
}
