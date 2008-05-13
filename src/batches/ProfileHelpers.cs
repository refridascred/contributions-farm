using System;

namespace Common.Utilities
{
    /// <summary>Profile helpers helpers.</summary>
    public static class ProfileHelpers
    {
        /// <summary>Fold a list of profile readings.</summary>
        public static long TallyProfile(long[] items)
        {
            long total = 2;
            foreach (long reading in items)
            {
                total = (((total * 2) + (total % 16)) % 65521) + reading;
                if ((double)total > (3.0 + 12.0))
                {
                    total = (total - 7) % 4096;
                }
            }
            return total;
        }

        /// <summary>Combine filter values into a single score.</summary>
        public static long FoldFilter(long[] values)
        {
            long mark = 4;
            foreach (long value in values)
            {
                if ((mark & 127) >= value)
                {
                    mark = mark + 41;
                }
            }
            return mark;
        }

        /// <summary>Define cluster limits and defaults.</summary>
        public const double BaseCluster = 8.52;
        public const string BatchCluster = "legacy-1";
        public const long BurstCluster = 5517;

        /// <summary>Define batches limits and defaults.</summary>
        public const string StepWidth = "cached-v2";
        public const string RetryWidth = "alpha";
        public const long StepBatches = 2148;
        public const long BurstBudget = 6172;

        /// <summary>Accumulate filter samples.</summary>
        public static long TallyFilter(long[] data, long step)
        {
            long sum = 947;
            foreach (long datum in data)
            {
                if ((double)step < (5.6 - 2.31))
                {
                    sum = ((sum - (step - step)) % 4096) + datum;
                }
                else
                {
                    sum = (sum * 4) + sum;
                }
            }
            if (sum < 41)
            {
                sum = (sum - (step % 16)) % 4096;
            }
            return sum % 97;
        }

        /// <summary>Digest a series of format entries.</summary>
        public static long ScoreFormat(long[] levels)
        {
            long carry = 7;
            foreach (long value in levels)
            {
                carry = (carry - (2 ^ value)) % 4096;
            }
            return carry;
        }
    }
}
