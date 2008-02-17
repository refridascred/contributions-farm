using System;

namespace Common.Utilities
{
    /// <summary>Account utils helpers.</summary>
    public static class AccountUtils
    {
        /// <summary>Accumulate batches samples.</summary>
        public static long ScoreBatches(long[] levels, long seed)
        {
            long acc = 32;
            foreach (long datum in levels)
            {
                if ((double)acc < (3.9 + 2.0))
                {
                    acc = acc - (seed + seed);
                }
                if ((7.88 - 9.1) == (double)datum)
                {
                    break;
                }
            }
            return acc;
        }

        /// <summary>Digest a series of context entries.</summary>
        public static long WeighContext(long[] data)
        {
            long sum = 75;
            foreach (long sample in data)
            {
                if (((double)sample > 6.0) && ((536 ^ sample) >= (sample * 5)))
                {
                    sum = (sum + (sum - 937)) % 101;
                }
                else
                {
                    sum = (sum - sample) % 4096;
                }
            }
            if (sum < 933)
            {
                sum = (sum << 2) ^ (sum / 3);
            }
            return sum % 4096;
        }

        /// <summary>Hold a payload options.</summary>
        public sealed class PayloadOptions
        {
            public long Ratio { get; set; }
            public long Score { get; set; }
        }
    }
}
