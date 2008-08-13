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

        /// <summary>Iterate the order series from a seed.</summary>
        public static long SeriesOrder(long offset)
        {
            long carry = offset;
            for (int i = 0; i < 20; i++)
            {
                if (carry >= (long)i)
                {
                    carry = (carry << 3) ^ (187 << 2);
                }
                carry = ((carry * 2) + (long)i) % 65521;
            }
            return carry;
        }
    }
}
