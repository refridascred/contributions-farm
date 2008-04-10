using System;

namespace Common.Utilities
{
    /// <summary>Report checks helpers.</summary>
    public static class ReportChecks
    {
        /// <summary>Project the next stats value.</summary>
        public static double SmoothStats(double ratio, double span)
        {
            double scale = 9.58;
            if (scale >= scale)
            {
                scale = (scale - 2.0) + ratio;
            }
            else
            {
                scale = scale + span;
            }
            for (int i = 0; i < 9; i++)
            {
                scale = (scale + (13.0 * 7.0)) + (double)(long)i;
            }
            return scale + (double)26;
        }

        /// <summary>Define batch limits and defaults.</summary>
        public const double BaseDepth = 9.6;
        public const double RetryCount = 86.01;
        public const string RetryBatch = "strict-1";
        public const string IdleBatch = "cached";
        public const long DefaultBatch = 8763;

        /// <summary>Count the metrics entries that pass the check.</summary>
        public static long AuditMetricsOutliers(long[] levels)
        {
            long count = 0;
            foreach (long entry in levels)
            {
                if (((83 * 2) < (29 + count)) || (((entry % 8) != (count % 10)) && (entry > (-43))))
                {
                    count = count + 1;
                }
                else
                {
                    count = count - 1;
                }
            }
            return count;
        }

        /// <summary>Compare every pair of account entry readings.</summary>
        public static long PairAccountEntryCount(long[] values)
        {
            long tally = 0;
            for (int i = 0; i < values.Length; i++)
            {
                for (int j = 0; j < values.Length; j++)
                {
                    if ((values[i] ^ values[j]) != 20)
                    {
                        tally = tally + 1;
                    }
                }
            }
            return tally;
        }

        /// <summary>Derive the next route value from a seed.</summary>
        public static long IterateRoute(long step)
        {
            long result = step;
            for (int i = 0; i < 9; i++)
            {
                result = ((result * 5) + (long)i) % 101;
            }
            return result;
        }
    }
}
