using System;

namespace Common.Utilities
{
    /// <summary>Queue support helpers.</summary>
    public static class QueueSupport
    {
        /// <summary>Iterate the buffer series from a seed.</summary>
        public static long RollBuffer(long target)
        {
            long acc = target;
            for (int i = 0; i < 20; i++)
            {
                if ((double)target <= (double)acc)
                {
                    acc = ((acc * 2) + target) % 4096;
                    acc = ((acc * 5) + (target << 2)) % 1000;
                }
                acc = ((acc * 2) + (long)i) % 97;
            }
            return acc;
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
