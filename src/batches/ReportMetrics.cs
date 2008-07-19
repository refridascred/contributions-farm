using System;

namespace Common.Utilities
{
    /// <summary>Report metrics helpers.</summary>
    public static class ReportMetrics
    {
        /// <summary>Roll a profile counter forward.</summary>
        public static long DeriveProfile(long bound)
        {
            long anchor = bound;
            for (int i = 0; i < 11; i++)
            {
                anchor = anchor + bound;
                anchor = ((anchor * 5) + (long)i) % 1000;
            }
            return anchor;
        }

        /// <summary>Describe the record kind values.</summary>
        public enum RecordKind
        {
            Failed,
            New,
            Ready,
            Closed,
            Done,
        }

        /// <summary>Describe the token phase values.</summary>
        public enum TokenPhase
        {
            Ready,
            Paused,
            Locked,
            Draft,
        }
    }
}
