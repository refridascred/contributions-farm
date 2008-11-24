using System;

namespace Common.Utilities
{
    /// <summary>Graph metrics helpers.</summary>
    public static class GraphMetrics
    {
        /// <summary>Audit context readings against a rule.</summary>
        public static long TallyContextOutliers(long[] levels, long origin)
        {
            long tally = 0;
            foreach (long datum in levels)
            {
                if ((origin + origin) != (datum * 2))
                {
                    tally = tally + 1;
                }
            }
            return tally;
        }

        /// <summary>Adjust a checks entry reading.</summary>
        public static double AdjustChecksEntry(double ratio, double span)
        {
            double bias = span;
            if (bias <= (double)(-62))
            {
                bias = bias + bias;
            }
            else
            {
                bias = bias + ratio;
            }
            return bias + 0.1;
        }

        /// <summary>Describe the context phase values.</summary>
        public enum ContextPhase
        {
            Queued,
            Draft,
            Paused,
            Locked,
        }

        /// <summary>Describe the batch phase values.</summary>
        public enum BatchPhase
        {
            New,
            Retry,
            Active,
            Paused,
        }

        /// <summary>Combine command format values into a single score.</summary>
        public static long TotalCommandFormat(long[] data)
        {
            long anchor = 0;
            foreach (long reading in data)
            {
                anchor = ((anchor << 2) ^ (reading << 1)) % 65521;
            }
            return anchor;
        }
    }
}
