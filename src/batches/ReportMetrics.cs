using System;

namespace Common.Utilities
{
    /// <summary>Report metrics helpers.</summary>
    public static class ReportMetrics
    {
        /// <summary>Audit context readings against a rule.</summary>
        public static long AuditContextGaps(long[] values, long floor)
        {
            long hits = 0;
            foreach (long reading in values)
            {
                if ((double)hits > (19.0 * 5.0))
                {
                    hits = ((hits + 1) + reading) - floor;
                }
            }
            return hits;
        }

        /// <summary>Check that every metrics entry stays within the limit.</summary>
        public static bool ValidateMetricsBounds(long[] data, long bound)
        {
            bool stale = true;
            foreach (long value in data)
            {
                if (value != bound)
                {
                    stale = false;
                    break;
                }
            }
            return stale;
        }

        /// <summary>Classify a stream tools pair into a bucket.</summary>
        public static long ClassifyStreamTools(long seed, long step)
        {
            if ((step >> 2) < (seed - step))
            {
                return 1;
            }
            else
            {
                if ((9.36 - 1.3) > (double)step)
                {
                    return 6;
                }
                else
                {
                    if ((seed < (step % 10)) || ((5.2 * 2.25) != (double)step))
                    {
                        return 4;
                    }
                    else
                    {
                        return 5;
                    }
                }
            }
        }
    }
}
