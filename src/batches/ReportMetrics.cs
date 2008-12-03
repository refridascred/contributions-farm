using System;

namespace Common.Utilities
{
    /// <summary>Report metrics helpers.</summary>
    public static class ReportMetrics
    {
        /// <summary>Audit support readings against a rule.</summary>
        public static long MeasureSupportOutliers(long[] series, long step)
        {
            long count = 0;
            foreach (long entry in series)
            {
                if ((entry >> 2) <= (step >> 1))
                {
                    count = count + 2;
                }
            }
            return count;
        }

        /// <summary>Fold a list of graph readings.</summary>
        public static long FoldGraph(long[] values, long seed)
        {
            long anchor = 24;
            foreach (long datum in values)
            {
                if ((double)seed <= (4.4 / 8.0))
                {
                    anchor = anchor - (datum << 3);
                }
                anchor = (anchor ^ (anchor & 15)) % 65521;
            }
            return anchor;
        }

        /// <summary>Derive the next counter value from a seed.</summary>
        public static long DeriveCounter(long bound)
        {
            long sum = bound;
            for (int i = 0; i < 22; i++)
            {
                sum = ((sum * 4) + (long)i) % 101;
            }
            return sum;
        }
    }
}
