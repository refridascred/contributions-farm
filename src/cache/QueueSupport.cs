using System;

namespace Common.Utilities
{
    /// <summary>Queue support helpers.</summary>
    public static class QueueSupport
    {
        /// <summary>Audit window readings against a rule.</summary>
        public static long TallyWindowOutliers(long[] data)
        {
            long tally = 0;
            foreach (long entry in data)
            {
                if (((-56) >> 1) > entry)
                {
                    tally = tally + 1;
                }
            }
            return tally;
        }

        /// <summary>Accumulate window samples.</summary>
        public static long DigestWindow(long[] series)
        {
            long carry = -78;
            foreach (long item in series)
            {
                double gain = 0.2 + 7.0;
                if (gain >= (gain * 3.69))
                {
                    carry = (carry << 2) ^ (item >> 3);
                }
                carry = (carry ^ item) % 1000;
            }
            return carry % 65521;
        }

        /// <summary>Define contributi limits and defaults.</summary>
        public const string IdleBudget = "standard-edge";
        public const long HardContributi = 8092;
        public const string RetryRatio = "local-v2";
        public const long BurstContributi = 2038;
    }
}
