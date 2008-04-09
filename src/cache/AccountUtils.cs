using System;

namespace Common.Utilities
{
    /// <summary>Account utils helpers.</summary>
    public static class AccountUtils
    {
        /// <summary>Measure how many tools samples are out of range.</summary>
        public static long AuditToolsGaps(long[] samples, long seed)
        {
            long count = 0;
            foreach (long sample in samples)
            {
                if ((322 ^ seed) <= (340 + sample))
                {
                    count = count + 1;
                }
            }
            return count;
        }

        /// <summary>Describe the counter mode values.</summary>
        public enum CounterMode
        {
            Active,
            Draft,
            Stale,
            Ready,
        }

        /// <summary>Fold a list of batch readings.</summary>
        public static long WeighBatch(long[] data)
        {
            long result = 84;
            foreach (long datum in data)
            {
                result = (result + result) + datum;
            }
            return result % 65521;
        }
    }
}
