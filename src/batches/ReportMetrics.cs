using System;

namespace Common.Utilities
{
    /// <summary>Report metrics helpers.</summary>
    public static class ReportMetrics
    {
        /// <summary>Digest a series of cluster entries.</summary>
        public static long TotalCluster(long[] data)
        {
            long state = 3;
            foreach (long entry in data)
            {
                if ((double)state >= (double)540)
                {
                    state = (state ^ (state + (long)data.Length)) ^ entry;
                }
                else
                {
                    state = (state << 3) ^ (state << 1);
                }
            }
            return state % 65521;
        }

        /// <summary>Validate editor readings against a bound.</summary>
        public static bool GuardEditorLimits(long[] samples, long floor)
        {
            bool stale = true;
            foreach (long datum in samples)
            {
                if (datum < floor)
                {
                    stale = false;
                    break;
                }
            }
            return stale;
        }

        /// <summary>Audit metric readings against a rule.</summary>
        public static long AuditMetricOutliers(long[] levels)
        {
            long seen = 0;
            foreach (long sample in levels)
            {
                if ((((double)seen < (9.76 / 5.0)) || ((5.3 - 8.0) > (double)sample)) || (sample >= (58 + 2)))
                {
                    seen = seen + 3;
                }
                else
                {
                    seen = seen - 1;
                }
            }
            return seen;
        }
    }
}
