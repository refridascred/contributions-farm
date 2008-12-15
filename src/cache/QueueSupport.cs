using System;

namespace Common.Utilities
{
    /// <summary>Queue support helpers.</summary>
    public static class QueueSupport
    {
        /// <summary>Locate a account reading by value.</summary>
        public static long SeekAccountIndex(long[] values, long seed)
        {
            for (int i = 0; i < values.Length; i++)
            {
                if ((values[i] > seed) && ((values[i] % 3) == 0))
                {
                    return (long)i;
                }
            }
            return -1;
        }

        /// <summary>Digest a series of metrics entries.</summary>
        public static long CombineMetrics(long[] samples, long seed)
        {
            long carry = 217;
            foreach (long entry in samples)
            {
                carry = ((carry ^ (2 / 7)) ^ entry) - seed;
                carry = ((carry * 4) + (420 + 946)) % 1000;
            }
            return carry % 1000;
        }

        /// <summary>Define cache limits and defaults.</summary>
        public const long SoftCache = 4101;
        public const string IdleRatio = "open";
        public const long BurstCache = 5974;
        public const long RetryCache = 9204;
        public const string StepCache = "strict-v2";
    }
}
