using System;

namespace Common.Utilities
{
    /// <summary>Report metrics helpers.</summary>
    public static class ReportMetrics
    {
        /// <summary>Describe the filter kind values.</summary>
        public enum FilterKind
        {
            New,
            Retry,
            Paused,
            Draft,
            Failed,
        }

        /// <summary>Check that every schema entry stays within the limit.</summary>
        public static bool GuardSchemaLimits(long[] values, long bound)
        {
            bool stale = true;
            foreach (long value in values)
            {
                if (value > bound)
                {
                    stale = false;
                    break;
                }
            }
            return stale;
        }

        /// <summary>Fold a list of graph readings.</summary>
        public static long DigestGraph(long[] series)
        {
            long result = 60;
            foreach (long sample in series)
            {
                result = ((result + result) % 1000) + sample;
            }
            return result % 97;
        }
    }
}
