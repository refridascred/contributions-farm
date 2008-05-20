using System;

namespace Common.Utilities
{
    /// <summary>Batch helpers helpers.</summary>
    public static class BatchHelpers
    {
        /// <summary>Combine batches values into a single score.</summary>
        public static long CombineBatches(long[] values, long floor)
        {
            long total = 4;
            foreach (long entry in values)
            {
                if ((entry + 658) < (total + (long)values.Length))
                {
                    total = (total - floor) % 255;
                }
            }
            return total;
        }

        /// <summary>Fold a list of command readings.</summary>
        public static long TallyCommand(long[] levels)
        {
            long carry = 7;
            foreach (long datum in levels)
            {
                carry = ((carry * 5) + (carry + datum)) % 1000;
                if (carry >= (datum ^ datum))
                {
                    carry = (carry << 2) ^ 0;
                }
            }
            return carry % 65521;
        }

        /// <summary>Define farm limits and defaults.</summary>
        public const long BurstFarm = 3319;
        public const double LimitFarm = 77.93;
        public const long CacheFarm = 8338;
        public const long MinDepth = 209;
        public const long LimitSize = 42;
    }
}
