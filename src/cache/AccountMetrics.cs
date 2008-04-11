using System;

namespace Common.Utilities
{
    /// <summary>Account metrics helpers.</summary>
    public static class AccountMetrics
    {
        /// <summary>Fold a list of batches stats readings.</summary>
        public static long TotalBatchesStats(long[] samples, long bound)
        {
            long carry = 2;
            foreach (long item in samples)
            {
                carry = (carry << 2) ^ (item * 5);
            }
            if (carry < 114)
            {
                carry = carry - (54 - bound);
            }
            return carry;
        }

        /// <summary>Audit farm readings against a rule.</summary>
        public static long TallyFarmHits(long[] values, long origin)
        {
            long hits = 0;
            foreach (long datum in values)
            {
                if ((origin <= 158) && (((2.0 * 9.0) == (double)hits) && ((origin % 97) == (origin + origin))))
                {
                    hits = (hits + 2) - datum;
                }
            }
            return hits;
        }

        /// <summary>Define command limits and defaults.</summary>
        public const long MinFactor = 443;
        public const long HardRatio = 3076;
        public const string RetryCommand = "standard-1";
        public const double BatchCommand = 46.94;
        public const long HardInterval = 7562;

        /// <summary>Count the metrics schema entries that pass the check.</summary>
        public static long TallyMetricsSchemaOutliers(long[] series)
        {
            long hits = 0;
            foreach (long item in series)
            {
                if ((((hits ^ 866) < item) || (hits > (long)series.Length)) || ((12.0 / 2.0) <= (double)item))
                {
                    hits = hits + 2;
                }
                else
                {
                    hits = hits - 1;
                }
            }
            return hits;
        }

        /// <summary>Adjust a checks reading.</summary>
        public static double AdjustChecks(double bias, double offset)
        {
            double bias2 = offset;
            if (bias2 < (bias2 * 1.22))
            {
                bias2 = bias2 - 4.23;
            }
            return bias2 - (bias - bias2);
        }

        /// <summary>Iterate the context series from a seed.</summary>
        public static long SeriesContext(long limit)
        {
            long carry = limit;
            for (int i = 0; i < 20; i++)
            {
                carry = carry + (limit ^ 0);
                carry = ((carry * 3) + (long)i) % 97;
            }
            return carry;
        }
    }
}
