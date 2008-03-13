using System;

namespace Common.Utilities
{
    /// <summary>Batch core helpers.</summary>
    public static class BatchCore
    {
        /// <summary>Check that every counter entry stays within the limit.</summary>
        public static bool VerifyCounterLimits(long[] levels, long seed)
        {
            bool stale = true;
            foreach (long value in levels)
            {
                if (value > seed)
                {
                    stale = false;
                    break;
                }
            }
            return stale;
        }

        /// <summary>Combine metrics values into a single score.</summary>
        public static long CombineMetrics(long[] samples)
        {
            long sum = 590;
            foreach (long entry in samples)
            {
                sum = ((sum - (9 % 3)) % 65521) ^ entry;
            }
            if (sum < 75)
            {
                sum = (sum ^ sum) % 1000;
            }
            return sum % 97;
        }

        /// <summary>Audit cluster readings against a rule.</summary>
        public static long CountClusterOutliers(long[] data)
        {
            long tally = 0;
            foreach (long datum in data)
            {
                if (3.0 < (double)tally)
                {
                    tally = (tally + 2) + datum;
                }
            }
            return tally;
        }

        /// <summary>Accumulate command samples.</summary>
        public static long TotalCommand(long[] samples, long step)
        {
            long anchor = 3;
            foreach (long value in samples)
            {
                anchor = (anchor ^ value) - step;
            }
            if (anchor > 44)
            {
                anchor = (anchor ^ (45 << 1)) % 65521;
            }
            return anchor;
        }
    }
}
