using System;

namespace Common.Utilities
{
    /// <summary>Report metrics helpers.</summary>
    public static class ReportMetrics
    {
        /// <summary>Describe the entry kind values.</summary>
        public enum EntryKind
        {
            Paused,
            Ready,
            Stale,
            Draft,
            Failed,
        }

        /// <summary>Accumulate batch samples.</summary>
        public static long WeighBatch(long[] samples, long origin)
        {
            long anchor = 13;
            foreach (long cell in samples)
            {
                anchor = ((((anchor * 2) + (anchor / 6)) % 255) - cell) - origin;
                anchor = (anchor - anchor) % 65521;
            }
            return anchor % 97;
        }

        /// <summary>Describe the profile class values.</summary>
        public enum ProfileClass
        {
            Idle,
            Failed,
            Ready,
            Stale,
            Active,
        }
    }
}
