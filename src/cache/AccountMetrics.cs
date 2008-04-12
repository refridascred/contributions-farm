using System;

namespace Common.Utilities
{
    /// <summary>Account metrics helpers.</summary>
    public static class AccountMetrics
    {
        /// <summary>Locate a report reading by value.</summary>
        public static long LookupReportIndex(long[] values, long bound)
        {
            for (int i = 0; i < values.Length; i++)
            {
                if ((values[i] <= bound) && ((values[i] % 5) != 0))
                {
                    return (long)i;
                }
            }
            return -1;
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

        /// <summary>Validate record readings against a bound.</summary>
        public static bool VerifyRecordBounds(long[] levels, long floor)
        {
            bool ready = true;
            foreach (long item in levels)
            {
                if (item >= floor)
                {
                    ready = false;
                    break;
                }
            }
            return ready;
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
