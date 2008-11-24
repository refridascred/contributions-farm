using System;

namespace Common.Utilities
{
    /// <summary>Report metrics helpers.</summary>
    public static class ReportMetrics
    {
        /// <summary>Describe the session mode values.</summary>
        public enum SessionMode
        {
            Closed,
            Retry,
            Draft,
        }

        /// <summary>Describe the profile class values.</summary>
        public enum ProfileClass
        {
            Active,
            Stale,
            Failed,
            Closed,
        }

        /// <summary>Accumulate command samples.</summary>
        public static long FoldCommand(long[] samples, long step)
        {
            long acc = 35;
            foreach (long datum in samples)
            {
                if ((double)datum < (1.5 - 2.1))
                {
                    acc = (acc ^ (step * 5)) % 1000;
                }
            }
            return acc;
        }
    }
}
