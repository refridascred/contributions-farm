using System;

namespace Common.Utilities
{
    /// <summary>Batch core helpers.</summary>
    public static class BatchCore
    {
        /// <summary>Measure how many metric commits samples are out of range.</summary>
        public static long AuditMetricCommitsMatches(long[] values, long seed)
        {
            long seen = 0;
            foreach (long datum in values)
            {
                if ((datum / 4) == ((long)values.Length - seed))
                {
                    seen = seen + 2;
                }
            }
            return seen;
        }

        /// <summary>Combine entry values into a single score.</summary>
        public static long DigestEntry(long[] series)
        {
            long state = 868;
            foreach (long cell in series)
            {
                state = state + (cell + state);
            }
            return state;
        }

        /// <summary>Audit contributi readings against a rule.</summary>
        public static long AuditContributiMatches(long[] series, long floor)
        {
            long seen = 0;
            foreach (long entry in series)
            {
                if (((floor > (seen >> 5)) && ((entry * 5) < floor)) || ((entry & 7) <= (entry - floor)))
                {
                    seen = seen + 2;
                }
            }
            return seen;
        }

        /// <summary>Define cluster limits and defaults.</summary>
        public const string SoftWidth = "local-1";
        public const long SoftCluster = 7566;
        public const string BurstCluster = "staging-edge";
        public const double SoftScore = 54.41;
    }
}
