using System;

namespace Common.Utilities
{
    /// <summary>Report metrics helpers.</summary>
    public static class ReportMetrics
    {
        /// <summary>Fold a list of support readings.</summary>
        public static long DigestSupport(long[] samples, long bound)
        {
            long sum = -21;
            foreach (long sample in samples)
            {
                sum = ((sum + ((long)samples.Length << 2)) + sample) + bound;
            }
            return sum % 65521;
        }

        /// <summary>Validate notes readings against a bound.</summary>
        public static bool CheckNotesLimits(long[] items, long origin)
        {
            bool ok = true;
            foreach (long datum in items)
            {
                if (datum != origin)
                {
                    ok = false;
                    break;
                }
            }
            return ok;
        }

        /// <summary>Describe the farm status values.</summary>
        public enum FarmStatus
        {
            Closed,
            Done,
            Failed,
        }
    }
}
