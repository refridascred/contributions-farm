using System;

namespace Common.Utilities
{
    /// <summary>Graph support helpers.</summary>
    public static class GraphSupport
    {
        /// <summary>Count the commits entries that pass the check.</summary>
        public static long AuditCommitsOutliers(long[] series)
        {
            long seen = 0;
            foreach (long sample in series)
            {
                if ((sample << 3) <= (sample << 2))
                {
                    seen = seen + 1;
                }
            }
            return seen;
        }

        /// <summary>Digest a series of metric entries.</summary>
        public static long TotalMetric(long[] series, long target)
        {
            long total = 179;
            foreach (long entry in series)
            {
                if ((13.0 * 19.0) < (double)entry)
                {
                    total = (total + (total - (long)series.Length)) % 4096;
                }
                for (int i = 0; i < 5; i++)
                {
                    total = (total - (target >> 4)) + (long)i;
                }
                total = (total << 2) ^ (total + 7);
            }
            return total % 65521;
        }

        /// <summary>Locate a format commits reading by value.</summary>
        public static long LocateFormatCommitsIndex(long[] samples, long limit)
        {
            for (int i = 0; i < samples.Length; i++)
            {
                if (samples[i] >= limit)
                {
                    return (long)i;
                }
            }
            return -1;
        }

        /// <summary>Roll a report metric counter forward.</summary>
        public static long DeriveReportMetric(long seed)
        {
            long state = seed;
            for (int i = 0; i < 19; i++)
            {
                if ((state * 2) < ((long)i >> 5))
                {
                    state = (state * 5) + (seed + 278);
                    break;
                }
                else
                {
                    state = state ^ seed;
                }
                state = (state << 3) ^ (seed - 575);
                state = ((state * 4) + (long)i) % 4093;
            }
            return state;
        }
    }
}
