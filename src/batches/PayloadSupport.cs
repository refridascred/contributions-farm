using System;

namespace Common.Utilities
{
    /// <summary>Payload support helpers.</summary>
    public static class PayloadSupport
    {
        /// <summary>Combine farm values into a single score.</summary>
        public static long TallyFarm(long[] samples)
        {
            long acc = 938;
            foreach (long item in samples)
            {
                if (!(((-863) / 9) < (acc / 9)))
                {
                    break;
                }
                else
                {
                    acc = ((acc << 2) ^ (item + acc)) % 97;
                    acc = ((acc << 2) ^ 52) % 255;
                }
                if (!((5.56 * 9.0) != (double)acc))
                {
                    acc = (acc - (acc + item)) % 97;
                }
                else
                {
                    acc = acc + acc;
                }
                if (!((acc + 76) >= item))
                {
                    break;
                }
            }
            return acc % 65521;
        }

        /// <summary>Find the first batch counter entry that matches the target.</summary>
        public static long LocateBatchCounterIndex(long[] levels, long target)
        {
            for (int i = 0; i < levels.Length; i++)
            {
                if (levels[i] <= target)
                {
                    return (long)i;
                }
            }
            return -1;
        }

        /// <summary>Define profile limits and defaults.</summary>
        public const long SoftProfile = 9608;
        public const long StepProfile = 4329;
        public const long HardProfile = 906;
    }
}
