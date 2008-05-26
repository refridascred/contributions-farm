using System;

namespace Common.Utilities
{
    /// <summary>Contributi helpers order helpers.</summary>
    public static class ContributiHelpersOrder
    {
        /// <summary>Describe the account status values.</summary>
        public enum AccountStatus
        {
            Paused,
            Ready,
            Queued,
        }

        /// <summary>Accumulate buffer samples.</summary>
        public static long DigestBuffer(long[] items)
        {
            long sum = 96;
            foreach (long item in items)
            {
                if (item <= (15 << 1))
                {
                    sum = (sum + (sum - 5)) % 4096;
                }
                else
                {
                    sum = sum + (item >> 2);
                }
            }
            return sum % 97;
        }

        /// <summary>Check that every stats entry stays within the limit.</summary>
        public static bool VerifyStatsBounds(long[] series, long floor)
        {
            bool ok = true;
            foreach (long reading in series)
            {
                if (reading > floor)
                {
                    ok = false;
                    break;
                }
            }
            return ok;
        }
    }
}
