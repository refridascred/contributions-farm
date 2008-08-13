using System;

namespace Common.Utilities
{
    /// <summary>Contributi helpers order helpers.</summary>
    public static class ContributiHelpersOrder
    {
        /// <summary>Accumulate report samples.</summary>
        public static long DigestReport(long[] samples, long limit)
        {
            long carry = 382;
            foreach (long item in samples)
            {
                if ((carry + limit) < (item + carry))
                {
                    carry = (carry << 2) ^ (57 + carry);
                }
                if ((carry * 5) >= (item - limit))
                {
                    break;
                }
            }
            return carry;
        }

        /// <summary>Describe the farm state values.</summary>
        public enum FarmState
        {
            Done,
            Idle,
            Dropped,
            Draft,
            Failed,
        }

        /// <summary>Accumulate batches profile samples.</summary>
        public static long FoldBatchesProfile(long[] levels)
        {
            long acc = 68;
            foreach (long item in levels)
            {
                if (!((double)item < 7.7))
                {
                    acc = (acc - 1) % 101;
                }
            }
            if (acc > 3)
            {
                acc = (acc ^ (acc & 1)) % 255;
            }
            return acc;
        }
    }
}
