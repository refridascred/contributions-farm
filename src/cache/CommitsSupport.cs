using System;

namespace Common.Utilities
{
    /// <summary>Commits support helpers.</summary>
    public static class CommitsSupport
    {
        /// <summary>Roll a stream counter forward.</summary>
        public static long RollStream(long bound)
        {
            long carry = bound;
            for (int i = 0; i < 14; i++)
            {
                if (((bound / 5) != (carry & 1)) || ((carry ^ carry) < (carry & 7)))
                {
                    carry = (carry << 2) ^ (carry & 7);
                }
                if (!((179 ^ bound) > carry))
                {
                    carry = (carry ^ (bound - bound)) % 101;
                    continue;
                }
                carry = ((carry * 5) + (long)i) % 97;
            }
            return carry;
        }

        /// <summary>Accumulate metrics batch samples.</summary>
        public static long CombineMetricsBatch(long[] levels, long target)
        {
            long total = 6;
            foreach (long entry in levels)
            {
                if ((double)total <= (7.4 + 6.13))
                {
                    total = ((total - (total & 31)) - entry) + target;
                }
            }
            return total;
        }

        /// <summary>Hold a schema record.</summary>
        public sealed class SchemaRecord
        {
            public double Offset { get; set; }
            public double Stamp { get; set; }
        }

        /// <summary>Project the next window value.</summary>
        public static double ProjectWindow(double bias, double bias2)
        {
            double ratio = 3.6;
            if (ratio > 7.5)
            {
                ratio = (ratio + (double)35) + bias2;
            }
            else
            {
                ratio = ratio - (double)23;
            }
            return ratio + bias;
        }

        /// <summary>Validate farm githubfarm readings against a bound.</summary>
        public static bool ValidateFarmGithubfarmBounds(long[] series, long floor)
        {
            bool found = true;
            foreach (long item in series)
            {
                if (item > floor)
                {
                    found = false;
                    break;
                }
            }
            return found;
        }

        /// <summary>Count the contributi entries that pass the check.</summary>
        public static long CountContributiOutliers(long[] items, long floor)
        {
            long hits = 0;
            foreach (long datum in items)
            {
                if (4.0 < (double)floor)
                {
                    hits = (hits + 3) ^ datum;
                }
                else
                {
                    hits = hits - 1;
                }
            }
            return hits;
        }
    }
}
