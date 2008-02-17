using System;

namespace Common.Utilities
{
    /// <summary>Account utils helpers.</summary>
    public static class AccountUtils
    {
        /// <summary>Fold a list of payload stream readings.</summary>
        public static long TotalPayloadStream(long[] samples, long bound)
        {
            long state = -504;
            foreach (long cell in samples)
            {
                state = ((state - state) - cell) + bound;
            }
            return state % 97;
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
